// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.ModelBuilder.Tests.TestModels;
using System;
using System.Linq;
using System.Linq.Expressions;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Commons
{
    public class PropertySelectorVisitorTest
    {
        [Fact]
        public void CanGetSingleSelectedProperty()
        {
            Expression<Func<AddressEntity, int>> expr = a => a.ID;
            var properties = PropertySelectorVisitor.GetSelectedProperties(expr).ToArray();
            Assert.Single(properties);
            Assert.Equal("ID", properties[0].Name);
        }

        [Fact]
        public void CanGetMultipleSelectedProperties()
        {
            var expr = Expr((AddressEntity a) => new { a.ID, a.ZipCode });
            var properties = PropertySelectorVisitor.GetSelectedProperties(expr).ToArray();
            Assert.Equal(2, properties.Length);
            Assert.Equal("ID", properties[0].Name);
            Assert.Equal("ZipCode", properties[1].Name);
        }

        [Fact]
        public void FailWhenLambdaExpressionAccessesFields()
        {
            Expression<Func<WorkItem, int>> expr = w => w.Field;
            var exception = ExceptionAssert.Throws<InvalidOperationException>(() =>
            {
                var properties = PropertySelectorVisitor.GetSelectedProperties(expr);
            });
            Assert.Equal(string.Format("Member '{0}.Field' is not a property.", typeof(WorkItem).FullName), exception.Message);
        }

        /// <summary>
        /// This silly method is just here to allow me to create an Expression for a Func returns an anonymous type
        /// so it can be held in a 'var'. 
        /// </summary>
        private static Expression<Func<TEntity, TProjection>> Expr<TEntity, TProjection>(Expression<Func<TEntity, TProjection>> select)
        {
            return select;
        }
    }

    public class AddressEntity
    {
        public int ID { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
    }
}
