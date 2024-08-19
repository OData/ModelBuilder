// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Moq;
using Moq.Protected;

namespace Microsoft.OData.ModelBuilder.Tests.Commons
{
    public sealed class MockType : Mock<Type>
    {
        public static implicit operator Type(MockType mockType)
        {
            return mockType.Object;
        }

        private readonly List<MockPropertyInfo> _propertyInfos = new List<MockPropertyInfo>();
        private MockType _baseType;

        public MockType()
            : this("T")
        {
        }

        public MockType(string typeName, bool hasDefaultCtor = true, string @namespace = "DefaultNamespace")
        {
            SetupGet(t => t.Name).Returns(typeName);
            SetupGet(t => t.BaseType).Returns(typeof(Object));
            SetupGet(t => t.Assembly).Returns(typeof(object).Assembly);
            Setup(t => t.GetProperties(It.IsAny<BindingFlags>()))
                .Returns(() => _propertyInfos.Union(_baseType != null ? _baseType._propertyInfos : Enumerable.Empty<MockPropertyInfo>()).Select(p => p.Object).ToArray());
            Setup(t => t.Equals(It.IsAny<object>())).Returns<Type>(t => ReferenceEquals(Object, t));
            Setup(t => t.ToString()).Returns(typeName);
            Setup(t => t.Namespace).Returns(@namespace);
            Setup(t => t.IsAssignableFrom(It.IsAny<Type>())).Returns(true);
            Setup(t => t.FullName).Returns(@namespace + "." + typeName);

            TypeAttributes(System.Reflection.TypeAttributes.Class | System.Reflection.TypeAttributes.Public);


            if (hasDefaultCtor)
            {
                this.Protected()
                    .Setup<ConstructorInfo>(
                        "GetConstructorImpl",
                        BindingFlags.Instance | BindingFlags.Public,
                        ItExpr.IsNull<Binder>(),
                        CallingConventions.Standard | CallingConventions.VarArgs,
                        Type.EmptyTypes,
                        ItExpr.IsNull<ParameterModifier[]>())
                    .Returns(new Mock<ConstructorInfo>().Object);
            }
        }

        public MockType TypeAttributes(TypeAttributes typeAttributes)
        {
            this.Protected()
                .Setup<TypeAttributes>("GetAttributeFlagsImpl")
                .Returns(typeAttributes);

            return this;
        }

        public MockType BaseType(MockType mockBaseType)
        {
            _baseType = mockBaseType;
            SetupGet(t => t.BaseType).Returns(mockBaseType);
            Setup(t => t.IsSubclassOf(mockBaseType)).Returns(true);

            return this;
        }

        public MockType Property<T>(string propertyName)
        {
            Property(typeof(T), propertyName);

            return this;
        }

        public MockType Property(Type propertyType, string propertyName, params Attribute[] attributes)
        {
            var mockPropertyInfo = new MockPropertyInfo(propertyType, propertyName);
            mockPropertyInfo.SetupGet(p => p.DeclaringType).Returns(this);
            mockPropertyInfo.SetupGet(p => p.ReflectedType).Returns(this);

            // The model builder does checks custom property attributes to support some featuers ([Required], [Contained], etc.)
            // So we have to mock the GetCustomAttributes methods. There are two overloads that we need worry about.
            // - object[] GetCustomAttributes(bool inherit)
            // - object[] GetCustomAttributes(Type attributeType, bool inherit)

            // Let's start with the first overload. It should return all the attributes without
            // filtering on type.
            mockPropertyInfo.Setup(p => p.GetCustomAttributes(It.IsAny<bool>())).Returns(attributes);

            // The second overload is a bit more complicated. This overload is also called internally
            // by extension methods like propertyInfo.GetCustomAttribute<T> or GetCustomAttributes<T>()
            // The overload should only return attributes of the specified type.
            // We should ensure that we also return an array of the specific attribute type, even if it's empty.
            // For example, if we call property.GetCustomAttributes<MyAttribute>(), we should return
            // an instance of MyAttribute[], not an instance of object[] or Attribute[] that only contains MyAttribute values.
            // This should be the case even if the array is empty. Which means we should mock any possible Attribute type.
            // This is important because MyAttribute[] can always be cast to Attribute[], but Attribute[] cannot always be cast to MyAttribute[]
            // Returning the wrong type will cause .NET to throw invalid cast exceptions.

            // We first start with a general catch-call case that returns an empty array of the input attribute type
            // for any attribute type the method is called with.
            mockPropertyInfo.Setup(p => p.GetCustomAttributes(It.IsAny<Type>(), It.IsAny<bool>()))
                .Returns((Type attributeType, bool inherit) => Activator.CreateInstance(attributeType.MakeArrayType(), [0]) as object[]);

            // Then for attributes that have been passed, we create specific mocks to handle their types and return corresponding arrays.
            foreach (var attribute in attributes)
            {
                // Let's say attribute is of type MyAttribute, the following is equivalent of doing:
                // MyAttribute[] attributeArray = new MyAttribute[] { attribute };
                var attributeType = attribute.GetType();
                var attributeArrayType = attributeType.MakeArrayType();
                var attributeArray = (object[])Activator.CreateInstance(attributeArrayType, [1]); // Create array of length 1
                attributeArray[0] = attribute;
                // This assumes that the property only has one instance of each property type. We don't handle the case where
                // the multiple attributes of the same type are applied to the same property. If we ever have such a use case
                // we should probably avoid mocks and just defined real types to avoid complicating this method further.
                mockPropertyInfo.Setup(p => p.GetCustomAttributes(It.Is<Type>(t => t == attributeType), It.IsAny<bool>())).Returns(attributeArray);
            }

            _propertyInfos.Add(mockPropertyInfo);

            return this;
        }

        public MockPropertyInfo GetProperty(string name)
        {
            return _propertyInfos.Single(p => p.Object.Name == name);
        }

        public MockType AsCollection()
        {
            var mockCollectionType = new MockType();

            mockCollectionType.Setup(t => t.GetInterfaces()).Returns(new Type[] { typeof(IEnumerable<>).MakeGenericType(this) });

            return mockCollectionType;
        }
    }
}
