[
FlagsAttribute(),
]
public enum Microsoft.OData.ModelBuilder.NameResolverOptions : int {
	ProcessDataMemberAttributePropertyNames = 2
	ProcessExplicitPropertyNames = 4
	ProcessReflectedPropertyNames = 1
}

public enum Microsoft.OData.ModelBuilder.NavigationPropertyBindingOption : int {
	Auto = 1
	None = 0
}

public enum Microsoft.OData.ModelBuilder.OperationKind : int {
	Action = 0
	Function = 1
}

public enum Microsoft.OData.ModelBuilder.PropertyKind : int {
	Collection = 2
	Complex = 1
	Dynamic = 5
	Enum = 4
	Navigation = 3
	Primitive = 0
}

public enum Microsoft.OData.ModelBuilder.SelectExpandType : int {
	Allowed = 0
	Automatic = 1
	Disabled = 2
}

public interface Microsoft.OData.ModelBuilder.IAssemblyResolver {
	System.Collections.Generic.IEnumerable`1[[System.Reflection.Assembly]] Assemblies  { public abstract get; }
}

public interface Microsoft.OData.ModelBuilder.IEdmTypeConfiguration {
	System.Type ClrType  { public abstract get; }
	string FullName  { public abstract get; }
	Microsoft.OData.Edm.EdmTypeKind Kind  { public abstract get; }
	Microsoft.OData.ModelBuilder.ODataModelBuilder ModelBuilder  { public abstract get; }
	string Name  { public abstract get; }
	string Namespace  { public abstract get; }
}

public interface Microsoft.OData.ModelBuilder.IODataModelConvention {
}

public abstract class Microsoft.OData.ModelBuilder.NavigationSourceConfiguration {
	protected NavigationSourceConfiguration ()
	protected NavigationSourceConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType, string name)
	protected NavigationSourceConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, System.Type entityClrType, string name)

	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration]] Bindings  { public get; }
	System.Type ClrType  { public get; }
	Microsoft.OData.ModelBuilder.EntityTypeConfiguration EntityType  { public virtual get; }
	string Name  { public get; }

	public virtual Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration AddBinding (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationConfiguration, Microsoft.OData.ModelBuilder.NavigationSourceConfiguration targetNavigationSource)
	public virtual Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration AddBinding (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationConfiguration, Microsoft.OData.ModelBuilder.NavigationSourceConfiguration targetNavigationSource, System.Collections.Generic.IList`1[[System.Reflection.MemberInfo]] bindingPath)
	public virtual System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration]] FindBinding (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationConfiguration)
	public virtual Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration FindBinding (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationConfiguration, System.Collections.Generic.IList`1[[System.Reflection.MemberInfo]] bindingPath)
	public virtual System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration]] FindBindings (string propertyName)
	public virtual string GetUrl ()
	public virtual void RemoveBinding (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationConfiguration)
	public virtual void RemoveBinding (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationConfiguration, string bindingPath)
}

public abstract class Microsoft.OData.ModelBuilder.NavigationSourceConfiguration`1 {
	BindingPathConfiguration`1 Binding  { public get; }
	EntityTypeConfiguration`1 EntityType  { public get; }

	public System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration]] FindBinding (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationConfiguration)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration FindBinding (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationConfiguration, System.Collections.Generic.IList`1[[System.Reflection.MemberInfo]] bindingPath)
	public System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration]] FindBindings (string propertyName)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasManyBinding (Expression`1 navigationExpression, NavigationSourceConfiguration`1 targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasManyBinding (Expression`1 navigationExpression, NavigationSourceConfiguration`1 targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasManyBinding (Expression`1 navigationExpression, string entitySetName)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasManyBinding (Expression`1 navigationExpression, string entitySetName)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasOptionalBinding (Expression`1 navigationExpression, NavigationSourceConfiguration`1 targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasOptionalBinding (Expression`1 navigationExpression, NavigationSourceConfiguration`1 targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasOptionalBinding (Expression`1 navigationExpression, string entitySetName)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasOptionalBinding (Expression`1 navigationExpression, string entitySetName)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasRequiredBinding (Expression`1 navigationExpression, NavigationSourceConfiguration`1 targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasRequiredBinding (Expression`1 navigationExpression, NavigationSourceConfiguration`1 targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasRequiredBinding (Expression`1 navigationExpression, string entitySetName)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasRequiredBinding (Expression`1 navigationExpression, string entitySetName)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasSingletonBinding (Expression`1 navigationExpression, NavigationSourceConfiguration`1 targetSingleton)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasSingletonBinding (Expression`1 navigationExpression, NavigationSourceConfiguration`1 targetSingleton)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasSingletonBinding (Expression`1 navigationExpression, string singletonName)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasSingletonBinding (Expression`1 navigationExpression, string singletonName)
}

public abstract class Microsoft.OData.ModelBuilder.OperationConfiguration {
	Microsoft.OData.ModelBuilder.BindingParameterConfiguration BindingParameter  { public virtual get; }
	System.Collections.Generic.IEnumerable`1[[System.String]] EntitySetPath  { public get; }
	bool FollowsConventions  { public get; protected set; }
	string FullyQualifiedName  { public get; }
	bool IsBindable  { public virtual get; }
	bool IsComposable  { public virtual get; }
	bool IsSideEffecting  { public abstract get; }
	Microsoft.OData.ModelBuilder.OperationKind Kind  { public abstract get; }
	Microsoft.OData.ModelBuilder.ODataModelBuilder ModelBuilder  { protected get; protected set; }
	string Name  { public get; protected set; }
	string Namespace  { public get; public set; }
	Microsoft.OData.ModelBuilder.NavigationSourceConfiguration NavigationSource  { public get; public set; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.ParameterConfiguration]] Parameters  { public virtual get; }
	bool ReturnNullable  { public get; public set; }
	Microsoft.OData.ModelBuilder.IEdmTypeConfiguration ReturnType  { public get; public set; }
	string Title  { public get; public set; }

	public Microsoft.OData.ModelBuilder.ParameterConfiguration AddParameter (string name, Microsoft.OData.ModelBuilder.IEdmTypeConfiguration parameterType)
	public Microsoft.OData.ModelBuilder.ParameterConfiguration CollectionEntityParameter (string name)
	public Microsoft.OData.ModelBuilder.ParameterConfiguration CollectionParameter (string name)
	public Microsoft.OData.ModelBuilder.ParameterConfiguration EntityParameter (string name)
	public Microsoft.OData.ModelBuilder.ParameterConfiguration Parameter (string name)
	public Microsoft.OData.ModelBuilder.ParameterConfiguration Parameter (System.Type clrParameterType, string name)
}

public abstract class Microsoft.OData.ModelBuilder.ParameterConfiguration {
	protected ParameterConfiguration (string name, Microsoft.OData.ModelBuilder.IEdmTypeConfiguration parameterType)

	string DefaultValue  { public get; protected set; }
	bool IsOptional  { public get; protected set; }
	string Name  { public get; protected set; }
	bool Nullable  { public get; public set; }
	Microsoft.OData.ModelBuilder.IEdmTypeConfiguration TypeConfiguration  { public get; protected set; }

	public Microsoft.OData.ModelBuilder.ParameterConfiguration HasDefaultValue (string defaultValue)
	public Microsoft.OData.ModelBuilder.ParameterConfiguration Optional ()
	public Microsoft.OData.ModelBuilder.ParameterConfiguration Required ()
}

public abstract class Microsoft.OData.ModelBuilder.PropertyConfiguration {
	protected PropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	bool AddedExplicitly  { public get; public set; }
	bool AutoExpand  { public get; public set; }
	Microsoft.OData.ModelBuilder.StructuralTypeConfiguration DeclaringType  { public get; }
	bool DisableAutoExpandWhenSelectIsPresent  { public get; public set; }
	bool IsRestricted  { public get; }
	Microsoft.OData.ModelBuilder.PropertyKind Kind  { public abstract get; }
	string Name  { public get; public set; }
	bool NonFilterable  { public get; public set; }
	bool NotCountable  { public get; public set; }
	bool NotExpandable  { public get; public set; }
	bool NotFilterable  { public get; public set; }
	bool NotNavigable  { public get; public set; }
	bool NotSortable  { public get; public set; }
	int Order  { public get; public set; }
	System.Reflection.PropertyInfo PropertyInfo  { public get; }
	System.Type RelatedClrType  { public abstract get; }
	bool Unsortable  { public get; public set; }

	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsCountable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsExpandable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsFilterable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsNavigable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsNonFilterable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsNotCountable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsNotExpandable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsNotFilterable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsNotNavigable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsNotSortable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsSortable ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration IsUnsortable ()
}

public abstract class Microsoft.OData.ModelBuilder.StructuralPropertyConfiguration : Microsoft.OData.ModelBuilder.PropertyConfiguration {
	protected StructuralPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	bool ConcurrencyToken  { public get; public set; }
	bool NullableProperty  { public get; public set; }
}

public abstract class Microsoft.OData.ModelBuilder.StructuralTypeConfiguration : IEdmTypeConfiguration {
	protected StructuralTypeConfiguration ()
	protected StructuralTypeConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, System.Type clrType)

	bool AddedExplicitly  { public get; public set; }
	bool BaseTypeConfigured  { public virtual get; }
	Microsoft.OData.ModelBuilder.StructuralTypeConfiguration BaseTypeInternal  { protected virtual get; }
	System.Type ClrType  { public virtual get; }
	System.Reflection.PropertyInfo DynamicPropertyDictionary  { public get; }
	System.Collections.Generic.IDictionary`2[[System.Reflection.PropertyInfo],[Microsoft.OData.ModelBuilder.PropertyConfiguration]] ExplicitProperties  { protected get; }
	string FullName  { public virtual get; }
	System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Reflection.PropertyInfo]] IgnoredProperties  { public get; }
	System.Nullable`1[[System.Boolean]] IsAbstract  { public virtual get; public virtual set; }
	bool IsOpen  { public get; }
	Microsoft.OData.Edm.EdmTypeKind Kind  { public abstract get; }
	Microsoft.OData.ModelBuilder.ODataModelBuilder ModelBuilder  { public virtual get; }
	string Name  { public virtual get; public virtual set; }
	string Namespace  { public virtual get; public virtual set; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration]] NavigationProperties  { public virtual get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.PropertyConfiguration]] Properties  { public get; }
	System.Collections.Generic.IList`1[[System.Reflection.PropertyInfo]] RemovedProperties  { protected get; }

	internal virtual void AbstractImpl ()
	public virtual Microsoft.OData.ModelBuilder.CollectionPropertyConfiguration AddCollectionProperty (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.ComplexPropertyConfiguration AddComplexProperty (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration AddContainedNavigationProperty (System.Reflection.PropertyInfo navigationProperty, Microsoft.OData.Edm.EdmMultiplicity multiplicity)
	public virtual void AddDynamicPropertyDictionary (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.EnumPropertyConfiguration AddEnumProperty (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration AddNavigationProperty (System.Reflection.PropertyInfo navigationProperty, Microsoft.OData.Edm.EdmMultiplicity multiplicity)
	public virtual Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration AddProperty (System.Reflection.PropertyInfo propertyInfo)
	internal virtual void DerivesFromImpl (Microsoft.OData.ModelBuilder.StructuralTypeConfiguration baseType)
	internal virtual void DerivesFromNothingImpl ()
	public virtual void RemoveProperty (System.Reflection.PropertyInfo propertyInfo)
}

public abstract class Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 {
	protected StructuralTypeConfiguration`1 (Microsoft.OData.ModelBuilder.StructuralTypeConfiguration configuration)

	string FullName  { public get; }
	bool IsOpen  { public get; }
	string Name  { public get; public set; }
	string Namespace  { public get; public set; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.PropertyConfiguration]] Properties  { public get; }

	public Microsoft.OData.ModelBuilder.CollectionPropertyConfiguration CollectionProperty (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.ComplexPropertyConfiguration ComplexProperty (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration ContainsMany (Expression`1 navigationPropertyExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration ContainsOptional (Expression`1 navigationPropertyExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration ContainsRequired (Expression`1 navigationPropertyExpression)
	public Microsoft.OData.ModelBuilder.EnumPropertyConfiguration EnumProperty (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.EnumPropertyConfiguration EnumProperty (Expression`1 propertyExpression)
	public void HasDynamicProperties (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasMany (Expression`1 navigationPropertyExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasOptional (Expression`1 navigationPropertyExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasOptional (Expression`1 navigationPropertyExpression, Expression`1 referentialConstraintExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasOptional (Expression`1 navigationPropertyExpression, Expression`1 referentialConstraintExpression, Expression`1 partnerExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasOptional (Expression`1 navigationPropertyExpression, Expression`1 referentialConstraintExpression, Expression`1 partnerExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasRequired (Expression`1 navigationPropertyExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasRequired (Expression`1 navigationPropertyExpression, Expression`1 referentialConstraintExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasRequired (Expression`1 navigationPropertyExpression, Expression`1 referentialConstraintExpression, Expression`1 partnerExpression)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasRequired (Expression`1 navigationPropertyExpression, Expression`1 referentialConstraintExpression, Expression`1 partnerExpression)
	public virtual void Ignore (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.LengthPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.LengthPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.DecimalPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.DecimalPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration Property (Expression`1 propertyExpression)
}

[
ExtensionAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.EdmModelExtensions {
	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.NavigationSourceLinkBuilderAnnotation GetNavigationSourceLinkBuilder (Microsoft.OData.Edm.IEdmModel model, Microsoft.OData.Edm.IEdmNavigationSource navigationSource)

	[
	ExtensionAttribute(),
	]
	public static void SetNavigationSourceLinkBuilder (Microsoft.OData.Edm.IEdmModel model, Microsoft.OData.Edm.IEdmNavigationSource navigationSource, Microsoft.OData.ModelBuilder.NavigationSourceLinkBuilderAnnotation navigationSourceLinkBuilder)
}

[
ExtensionAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.ODataConventionModelBuilderExtensions {
	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.ODataConventionModelBuilder EnableLowerCamelCase (Microsoft.OData.ModelBuilder.ODataConventionModelBuilder builder)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.ODataConventionModelBuilder EnableLowerCamelCase (Microsoft.OData.ModelBuilder.ODataConventionModelBuilder builder, Microsoft.OData.ModelBuilder.NameResolverOptions options)
}

[
ExtensionAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.PrimitivePropertyConfigurationExtensions {
	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration AsDate (Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration property)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration AsTimeOfDay (Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration property)
}

public class Microsoft.OData.ModelBuilder.ActionConfiguration : Microsoft.OData.ModelBuilder.OperationConfiguration {
	bool IsSideEffecting  { public virtual get; }
	Microsoft.OData.ModelBuilder.OperationKind Kind  { public virtual get; }

	public Microsoft.OData.ModelBuilder.ActionConfiguration Returns ()
	public Microsoft.OData.ModelBuilder.ActionConfiguration Returns (System.Type clrReturnType)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollection ()
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionFromEntitySet (EntitySetConfiguration`1 entitySetConfiguration)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionFromEntitySet (string entitySetName)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionViaEntitySetPath (string entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionViaEntitySetPath (string[] entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsEntityViaEntitySetPath (string entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsEntityViaEntitySetPath (string[] entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsFromEntitySet (EntitySetConfiguration`1 entitySetConfiguration)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsFromEntitySet (string entitySetName)
	public Microsoft.OData.ModelBuilder.ActionConfiguration SetBindingParameter (string name, Microsoft.OData.ModelBuilder.IEdmTypeConfiguration bindingParameterType)
}

public class Microsoft.OData.ModelBuilder.BindingParameterConfiguration : Microsoft.OData.ModelBuilder.ParameterConfiguration {
	public static string DefaultBindingParameterName = "bindingParameter"

	public BindingParameterConfiguration (string name, Microsoft.OData.ModelBuilder.IEdmTypeConfiguration parameterType)
}

public class Microsoft.OData.ModelBuilder.BindingPathConfiguration`1 {
	public BindingPathConfiguration`1 (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, StructuralTypeConfiguration`1 structuralType, Microsoft.OData.ModelBuilder.NavigationSourceConfiguration navigationSource)
	public BindingPathConfiguration`1 (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, StructuralTypeConfiguration`1 structuralType, Microsoft.OData.ModelBuilder.NavigationSourceConfiguration navigationSource, System.Collections.Generic.IList`1[[System.Reflection.MemberInfo]] bindingPath)

	string BindingPath  { public get; }
	System.Collections.Generic.IList`1[[System.Reflection.MemberInfo]] Path  { public get; }

	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasManyBinding (Expression`1 navigationExpression, string targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasManyBinding (Expression`1 navigationExpression, string targetEntitySet)
	public BindingPathConfiguration`1 HasManyPath (Expression`1 pathExpression)
	public BindingPathConfiguration`1 HasManyPath (Expression`1 pathExpression)
	public BindingPathConfiguration`1 HasManyPath (Expression`1 pathExpression, bool contained)
	public BindingPathConfiguration`1 HasManyPath (Expression`1 pathExpression, bool contained)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasOptionalBinding (Expression`1 navigationExpression, string targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasOptionalBinding (Expression`1 navigationExpression, string targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasRequiredBinding (Expression`1 navigationExpression, string targetEntitySet)
	public Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration HasRequiredBinding (Expression`1 navigationExpression, string targetEntitySet)
	public BindingPathConfiguration`1 HasSinglePath (Expression`1 pathExpression)
	public BindingPathConfiguration`1 HasSinglePath (Expression`1 pathExpression)
	public BindingPathConfiguration`1 HasSinglePath (Expression`1 pathExpression, bool required, bool contained)
	public BindingPathConfiguration`1 HasSinglePath (Expression`1 pathExpression, bool required, bool contained)
}

public class Microsoft.OData.ModelBuilder.ClrEnumMemberAnnotation {
	public ClrEnumMemberAnnotation (System.Collections.Generic.IDictionary`2[[System.Enum],[Microsoft.OData.Edm.IEdmEnumMember]] map)

	public System.Enum GetClrEnumMember (Microsoft.OData.Edm.IEdmEnumMember edmEnumMember)
	public Microsoft.OData.Edm.IEdmEnumMember GetEdmEnumMember (System.Enum clrEnumMemberInfo)
}

public class Microsoft.OData.ModelBuilder.ClrPropertyInfoAnnotation {
	public ClrPropertyInfoAnnotation (System.Reflection.PropertyInfo clrPropertyInfo)

	System.Reflection.PropertyInfo ClrPropertyInfo  { public get; }
}

public class Microsoft.OData.ModelBuilder.ClrTypeAnnotation {
	public ClrTypeAnnotation (System.Type clrType)

	System.Type ClrType  { public get; }
}

public class Microsoft.OData.ModelBuilder.CollectionPropertyConfiguration : Microsoft.OData.ModelBuilder.StructuralPropertyConfiguration {
	public CollectionPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	System.Type ElementType  { public get; }
	Microsoft.OData.ModelBuilder.PropertyKind Kind  { public virtual get; }
	System.Type RelatedClrType  { public virtual get; }

	public Microsoft.OData.ModelBuilder.CollectionPropertyConfiguration IsNullable ()
	public Microsoft.OData.ModelBuilder.CollectionPropertyConfiguration IsRequired ()
}

public class Microsoft.OData.ModelBuilder.CollectionTypeConfiguration : IEdmTypeConfiguration {
	public CollectionTypeConfiguration (Microsoft.OData.ModelBuilder.IEdmTypeConfiguration elementType, System.Type clrType)

	System.Type ClrType  { public virtual get; }
	Microsoft.OData.ModelBuilder.IEdmTypeConfiguration ElementType  { public get; }
	string FullName  { public virtual get; }
	Microsoft.OData.Edm.EdmTypeKind Kind  { public virtual get; }
	Microsoft.OData.ModelBuilder.ODataModelBuilder ModelBuilder  { public virtual get; }
	string Name  { public virtual get; }
	string Namespace  { public virtual get; }
}

public class Microsoft.OData.ModelBuilder.ComplexPropertyConfiguration : Microsoft.OData.ModelBuilder.StructuralPropertyConfiguration {
	public ComplexPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	Microsoft.OData.ModelBuilder.PropertyKind Kind  { public virtual get; }
	System.Type RelatedClrType  { public virtual get; }

	public Microsoft.OData.ModelBuilder.ComplexPropertyConfiguration IsNullable ()
	public Microsoft.OData.ModelBuilder.ComplexPropertyConfiguration IsRequired ()
}

public class Microsoft.OData.ModelBuilder.ComplexTypeConfiguration : Microsoft.OData.ModelBuilder.StructuralTypeConfiguration, IEdmTypeConfiguration {
	public ComplexTypeConfiguration ()
	public ComplexTypeConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, System.Type clrType)

	Microsoft.OData.ModelBuilder.ComplexTypeConfiguration BaseType  { public virtual get; public virtual set; }
	Microsoft.OData.Edm.EdmTypeKind Kind  { public virtual get; }

	public virtual Microsoft.OData.ModelBuilder.ComplexTypeConfiguration Abstract ()
	public virtual Microsoft.OData.ModelBuilder.ComplexTypeConfiguration DerivesFrom (Microsoft.OData.ModelBuilder.ComplexTypeConfiguration baseType)
	public virtual Microsoft.OData.ModelBuilder.ComplexTypeConfiguration DerivesFromNothing ()
}

public class Microsoft.OData.ModelBuilder.ComplexTypeConfiguration`1 : StructuralTypeConfiguration`1 {
	Microsoft.OData.ModelBuilder.ComplexTypeConfiguration BaseType  { public get; }

	public Microsoft.OData.ModelBuilder.ComplexTypeConfiguration`1 Abstract ()
	public Microsoft.OData.ModelBuilder.ComplexTypeConfiguration`1 DerivesFrom ()
	public Microsoft.OData.ModelBuilder.ComplexTypeConfiguration`1 DerivesFromNothing ()
}

public class Microsoft.OData.ModelBuilder.ConcurrencyPropertiesAnnotation : System.Collections.Concurrent.ConcurrentDictionary`2[[Microsoft.OData.Edm.IEdmNavigationSource],[System.Collections.Generic.IEnumerable`1[[Microsoft.OData.Edm.IEdmStructuralProperty]]]], ICollection, IDictionary, IEnumerable, IDictionary`2, IReadOnlyDictionary`2, ICollection`1, IEnumerable`1, IReadOnlyCollection`1 {
	public ConcurrencyPropertiesAnnotation ()
}

public class Microsoft.OData.ModelBuilder.DecimalPropertyConfiguration : Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration {
	public DecimalPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	System.Nullable`1[[System.Int32]] Scale  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.DynamicPropertyDictionaryAnnotation {
	public DynamicPropertyDictionaryAnnotation (System.Reflection.PropertyInfo propertyInfo)

	System.Reflection.PropertyInfo PropertyInfo  { public get; }
}

public class Microsoft.OData.ModelBuilder.EntityCollectionConfiguration`1 : Microsoft.OData.ModelBuilder.CollectionTypeConfiguration, IEdmTypeConfiguration {
	public Microsoft.OData.ModelBuilder.ActionConfiguration Action (string name)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration Function (string name)
}

public class Microsoft.OData.ModelBuilder.EntitySetConfiguration : Microsoft.OData.ModelBuilder.NavigationSourceConfiguration {
	public EntitySetConfiguration ()
	public EntitySetConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType, string name)
	public EntitySetConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, System.Type entityClrType, string name)

	Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.DeleteRestrictionsBuilder DeleteRestrictions  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.EntitySetConfiguration`1 : NavigationSourceConfiguration`1 {
}

public class Microsoft.OData.ModelBuilder.EntityTypeConfiguration : Microsoft.OData.ModelBuilder.StructuralTypeConfiguration, IEdmTypeConfiguration {
	public EntityTypeConfiguration ()
	public EntityTypeConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, System.Type clrType)

	Microsoft.OData.ModelBuilder.EntityTypeConfiguration BaseType  { public virtual get; public virtual set; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.EnumPropertyConfiguration]] EnumKeys  { public virtual get; }
	bool HasStream  { public virtual get; public virtual set; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration]] Keys  { public virtual get; }
	Microsoft.OData.Edm.EdmTypeKind Kind  { public virtual get; }

	public virtual Microsoft.OData.ModelBuilder.EntityTypeConfiguration Abstract ()
	public virtual Microsoft.OData.ModelBuilder.EntityTypeConfiguration DerivesFrom (Microsoft.OData.ModelBuilder.EntityTypeConfiguration baseType)
	public virtual Microsoft.OData.ModelBuilder.EntityTypeConfiguration DerivesFromNothing ()
	public virtual Microsoft.OData.ModelBuilder.EntityTypeConfiguration HasKey (System.Reflection.PropertyInfo keyProperty)
	public virtual Microsoft.OData.ModelBuilder.EntityTypeConfiguration MediaType ()
	public virtual void RemoveKey (Microsoft.OData.ModelBuilder.EnumPropertyConfiguration enumKeyProperty)
	public virtual void RemoveKey (Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration keyProperty)
	public virtual void RemoveProperty (System.Reflection.PropertyInfo propertyInfo)
}

public class Microsoft.OData.ModelBuilder.EntityTypeConfiguration`1 : StructuralTypeConfiguration`1 {
	Microsoft.OData.ModelBuilder.EntityTypeConfiguration BaseType  { public get; }
	EntityCollectionConfiguration`1 Collection  { public get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration]] NavigationProperties  { public get; }

	public Microsoft.OData.ModelBuilder.EntityTypeConfiguration`1 Abstract ()
	public Microsoft.OData.ModelBuilder.ActionConfiguration Action (string name)
	public Microsoft.OData.ModelBuilder.EntityTypeConfiguration`1 DerivesFrom ()
	public Microsoft.OData.ModelBuilder.EntityTypeConfiguration`1 DerivesFromNothing ()
	public Microsoft.OData.ModelBuilder.FunctionConfiguration Function (string name)
	public Microsoft.OData.ModelBuilder.EntityTypeConfiguration`1 HasKey (Expression`1 keyDefinitionExpression)
	public Microsoft.OData.ModelBuilder.EntityTypeConfiguration`1 MediaType ()
}

public class Microsoft.OData.ModelBuilder.EnumMemberConfiguration {
	public EnumMemberConfiguration (System.Enum member, Microsoft.OData.ModelBuilder.EnumTypeConfiguration declaringType)

	bool AddedExplicitly  { public get; public set; }
	Microsoft.OData.ModelBuilder.EnumTypeConfiguration DeclaringType  { public get; }
	System.Enum MemberInfo  { public get; }
	string Name  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.EnumPropertyConfiguration : Microsoft.OData.ModelBuilder.StructuralPropertyConfiguration {
	public EnumPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	string DefaultValueString  { public get; public set; }
	Microsoft.OData.ModelBuilder.PropertyKind Kind  { public virtual get; }
	System.Type RelatedClrType  { public virtual get; }

	public Microsoft.OData.ModelBuilder.EnumPropertyConfiguration IsConcurrencyToken ()
	public Microsoft.OData.ModelBuilder.EnumPropertyConfiguration IsNullable ()
	public Microsoft.OData.ModelBuilder.EnumPropertyConfiguration IsRequired ()
}

public class Microsoft.OData.ModelBuilder.EnumTypeConfiguration : IEdmTypeConfiguration {
	public EnumTypeConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder builder, System.Type clrType)

	bool AddedExplicitly  { public get; public set; }
	System.Type ClrType  { public virtual get; }
	System.Collections.Generic.IDictionary`2[[System.Enum],[Microsoft.OData.ModelBuilder.EnumMemberConfiguration]] ExplicitMembers  { protected get; }
	string FullName  { public virtual get; }
	System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Enum]] IgnoredMembers  { public get; }
	bool IsFlags  { public get; }
	Microsoft.OData.Edm.EdmTypeKind Kind  { public virtual get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.EnumMemberConfiguration]] Members  { public get; }
	Microsoft.OData.ModelBuilder.ODataModelBuilder ModelBuilder  { public virtual get; }
	string Name  { public virtual get; public set; }
	string Namespace  { public virtual get; public set; }
	System.Collections.Generic.IList`1[[System.Enum]] RemovedMembers  { protected get; }
	System.Type UnderlyingType  { public get; }

	public Microsoft.OData.ModelBuilder.EnumMemberConfiguration AddMember (System.Enum member)
	public void RemoveMember (System.Enum member)
}

public class Microsoft.OData.ModelBuilder.EnumTypeConfiguration`1 {
	string FullName  { public get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.EnumMemberConfiguration]] Members  { public get; }
	string Name  { public get; public set; }
	string Namespace  { public get; public set; }

	public Microsoft.OData.ModelBuilder.EnumMemberConfiguration Member (TEnumType enumMember)
	public virtual void RemoveMember (TEnumType member)
}

public class Microsoft.OData.ModelBuilder.FunctionConfiguration : Microsoft.OData.ModelBuilder.OperationConfiguration {
	bool IncludeInServiceDocument  { public get; public set; }
	bool IsComposable  { public get; public set; }
	bool IsSideEffecting  { public virtual get; }
	Microsoft.OData.ModelBuilder.OperationKind Kind  { public virtual get; }
	bool SupportedInFilter  { public get; public set; }
	bool SupportedInOrderBy  { public get; public set; }

	public Microsoft.OData.ModelBuilder.FunctionConfiguration Returns ()
	public Microsoft.OData.ModelBuilder.FunctionConfiguration Returns (System.Type clrReturnType)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollection ()
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollectionFromEntitySet (string entitySetName)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollectionViaEntitySetPath (string entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollectionViaEntitySetPath (string[] entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsEntityViaEntitySetPath (string entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsEntityViaEntitySetPath (string[] entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsFromEntitySet (string entitySetName)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration SetBindingParameter (string name, Microsoft.OData.ModelBuilder.IEdmTypeConfiguration bindingParameterType)
}

public class Microsoft.OData.ModelBuilder.LengthPropertyConfiguration : Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration {
	public LengthPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	System.Nullable`1[[System.Int32]] MaxLength  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.LowerCamelCaser {
	public LowerCamelCaser ()
	public LowerCamelCaser (Microsoft.OData.ModelBuilder.NameResolverOptions options)

	public void ApplyLowerCamelCase (Microsoft.OData.ModelBuilder.ODataConventionModelBuilder builder)
	public virtual string ToLowerCamelCase (string name)
}

public class Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration {
	public NavigationPropertyBindingConfiguration (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationProperty, Microsoft.OData.ModelBuilder.NavigationSourceConfiguration navigationSource)
	public NavigationPropertyBindingConfiguration (Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration navigationProperty, Microsoft.OData.ModelBuilder.NavigationSourceConfiguration navigationSource, System.Collections.Generic.IList`1[[System.Reflection.MemberInfo]] path)

	string BindingPath  { public get; }
	Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration NavigationProperty  { public get; }
	System.Collections.Generic.IList`1[[System.Reflection.MemberInfo]] Path  { public get; }
	Microsoft.OData.ModelBuilder.NavigationSourceConfiguration TargetNavigationSource  { public get; }
}

public class Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration : Microsoft.OData.ModelBuilder.PropertyConfiguration {
	public NavigationPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.Edm.EdmMultiplicity multiplicity, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	bool ContainsTarget  { public get; }
	System.Collections.Generic.IEnumerable`1[[System.Reflection.PropertyInfo]] DependentProperties  { public get; }
	Microsoft.OData.ModelBuilder.PropertyKind Kind  { public virtual get; }
	Microsoft.OData.Edm.EdmMultiplicity Multiplicity  { public get; }
	Microsoft.OData.Edm.EdmOnDeleteAction OnDeleteAction  { public get; public set; }
	Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration Partner  { public get; }
	System.Collections.Generic.IEnumerable`1[[System.Reflection.PropertyInfo]] PrincipalProperties  { public get; }
	System.Type RelatedClrType  { public virtual get; }

	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration AutomaticallyExpand (bool disableWhenSelectIsPresent)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration CascadeOnDelete ()
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration CascadeOnDelete (bool cascade)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration Contained ()
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasConstraint (System.Collections.Generic.KeyValuePair`2[[System.Reflection.PropertyInfo],[System.Reflection.PropertyInfo]] constraint)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration HasConstraint (System.Reflection.PropertyInfo dependentPropertyInfo, System.Reflection.PropertyInfo principalPropertyInfo)
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration NonContained ()
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration Nullable ()
	public Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration Required ()
}

public class Microsoft.OData.ModelBuilder.NavigationSourceLinkBuilderAnnotation {
	public NavigationSourceLinkBuilderAnnotation ()
	public NavigationSourceLinkBuilderAnnotation (Microsoft.OData.Edm.IEdmNavigationSource navigationSource, Microsoft.OData.Edm.IEdmModel model)
}

public class Microsoft.OData.ModelBuilder.NonbindingParameterConfiguration : Microsoft.OData.ModelBuilder.ParameterConfiguration {
	public NonbindingParameterConfiguration (string name, Microsoft.OData.ModelBuilder.IEdmTypeConfiguration parameterType)
}

public class Microsoft.OData.ModelBuilder.ODataConventionModelBuilder : Microsoft.OData.ModelBuilder.ODataModelBuilder {
	public ODataConventionModelBuilder ()
	public ODataConventionModelBuilder (Microsoft.OData.ModelBuilder.IAssemblyResolver resolver)
	public ODataConventionModelBuilder (Microsoft.OData.ModelBuilder.IAssemblyResolver resolver, bool isQueryCompositionMode)

	bool ModelAliasingEnabled  { public get; public set; }
	System.Action`1[[Microsoft.OData.ModelBuilder.ODataConventionModelBuilder]] OnModelCreating  { public get; public set; }

	public virtual Microsoft.OData.ModelBuilder.ComplexTypeConfiguration AddComplexType (System.Type type)
	public virtual Microsoft.OData.ModelBuilder.EntitySetConfiguration AddEntitySet (string name, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType)
	public virtual Microsoft.OData.ModelBuilder.EntityTypeConfiguration AddEntityType (System.Type type)
	public virtual Microsoft.OData.ModelBuilder.EnumTypeConfiguration AddEnumType (System.Type type)
	public virtual Microsoft.OData.ModelBuilder.SingletonConfiguration AddSingleton (string name, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType)
	public virtual Microsoft.OData.Edm.IEdmModel GetEdmModel ()
	public Microsoft.OData.ModelBuilder.ODataConventionModelBuilder Ignore ()
	public Microsoft.OData.ModelBuilder.ODataConventionModelBuilder Ignore (System.Type[] types)
	public virtual void ValidateModel (Microsoft.OData.Edm.IEdmModel model)
}

public class Microsoft.OData.ModelBuilder.ODataModelBuilder {
	public ODataModelBuilder ()

	Microsoft.OData.ModelBuilder.NavigationPropertyBindingOption BindingOptions  { public get; public set; }
	string ContainerName  { public get; public set; }
	System.Version DataServiceVersion  { public get; public set; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.EntitySetConfiguration]] EntitySets  { public virtual get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.EnumTypeConfiguration]] EnumTypes  { public virtual get; }
	System.Version MaxDataServiceVersion  { public get; public set; }
	string Namespace  { public get; public set; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationSourceConfiguration]] NavigationSources  { public virtual get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.OperationConfiguration]] Operations  { public virtual get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.SingletonConfiguration]] Singletons  { public virtual get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.StructuralTypeConfiguration]] StructuralTypes  { public virtual get; }

	public virtual Microsoft.OData.ModelBuilder.ActionConfiguration Action (string name)
	public virtual Microsoft.OData.ModelBuilder.ComplexTypeConfiguration AddComplexType (System.Type clrType)
	public virtual Microsoft.OData.ModelBuilder.EntitySetConfiguration AddEntitySet (string name, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType)
	public virtual Microsoft.OData.ModelBuilder.EntityTypeConfiguration AddEntityType (System.Type clrType)
	public virtual Microsoft.OData.ModelBuilder.EnumTypeConfiguration AddEnumType (System.Type clrType)
	public virtual void AddOperation (Microsoft.OData.ModelBuilder.OperationConfiguration operation)
	public virtual Microsoft.OData.ModelBuilder.SingletonConfiguration AddSingleton (string name, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType)
	public ComplexTypeConfiguration`1 ComplexType ()
	public EntitySetConfiguration`1 EntitySet (string name)
	public EntityTypeConfiguration`1 EntityType ()
	public EnumTypeConfiguration`1 EnumType ()
	public virtual Microsoft.OData.ModelBuilder.FunctionConfiguration Function (string name)
	public virtual Microsoft.OData.Edm.IEdmModel GetEdmModel ()
	public Microsoft.OData.ModelBuilder.IEdmTypeConfiguration GetTypeConfigurationOrNull (System.Type type)
	public virtual bool RemoveEntitySet (string name)
	public virtual bool RemoveEnumType (System.Type clrType)
	public virtual bool RemoveOperation (Microsoft.OData.ModelBuilder.OperationConfiguration operation)
	public virtual bool RemoveOperation (string name)
	public virtual bool RemoveSingleton (string name)
	public virtual bool RemoveStructuralType (System.Type clrType)
	public SingletonConfiguration`1 Singleton (string name)
	public virtual void ValidateModel (Microsoft.OData.Edm.IEdmModel model)
}

public class Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration : Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration {
	public PrecisionPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	System.Nullable`1[[System.Int32]] Precision  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration : Microsoft.OData.ModelBuilder.StructuralPropertyConfiguration {
	public PrimitivePropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	string DefaultValueString  { public get; public set; }
	Microsoft.OData.ModelBuilder.PropertyKind Kind  { public virtual get; }
	System.Type RelatedClrType  { public virtual get; }
	System.Nullable`1[[Microsoft.OData.Edm.EdmPrimitiveTypeKind]] TargetEdmTypeKind  { public get; }

	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration IsConcurrencyToken ()
	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration IsNullable ()
	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration IsRequired ()
}

public class Microsoft.OData.ModelBuilder.PrimitiveTypeConfiguration : IEdmTypeConfiguration {
	System.Type ClrType  { public virtual get; }
	Microsoft.OData.Edm.IEdmPrimitiveType EdmPrimitiveType  { public get; }
	string FullName  { public virtual get; }
	Microsoft.OData.Edm.EdmTypeKind Kind  { public virtual get; }
	Microsoft.OData.ModelBuilder.ODataModelBuilder ModelBuilder  { public virtual get; }
	string Name  { public virtual get; }
	string Namespace  { public virtual get; }
}

public class Microsoft.OData.ModelBuilder.SingletonConfiguration : Microsoft.OData.ModelBuilder.NavigationSourceConfiguration {
	public SingletonConfiguration ()
	public SingletonConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType, string name)
	public SingletonConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, System.Type entityClrType, string name)
}

public class Microsoft.OData.ModelBuilder.SingletonConfiguration`1 : NavigationSourceConfiguration`1 {
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.ActionOnDeleteAttribute : System.Attribute {
	public ActionOnDeleteAttribute (Microsoft.OData.Edm.EdmOnDeleteAction onDeleteAction)

	Microsoft.OData.Edm.EdmOnDeleteAction OnDeleteAction  { public get; }
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.AutoExpandAttribute : System.Attribute {
	public AutoExpandAttribute ()

	bool DisableWhenSelectPresent  { public get; public set; }
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.ContainedAttribute : System.Attribute {
	public ContainedAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.CountAttribute : System.Attribute {
	public CountAttribute ()

	bool Disabled  { public get; public set; }
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.ExpandAttribute : System.Attribute {
	public ExpandAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.FilterAttribute : System.Attribute {
	public FilterAttribute ()
	public FilterAttribute (string[] properties)

	bool Disabled  { public get; public set; }
	System.Collections.Generic.Dictionary`2[[System.String],[System.Boolean]] FilterConfigurations  { public get; }
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.MediaTypeAttribute : System.Attribute {
	public MediaTypeAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.NonFilterableAttribute : System.Attribute {
	public NonFilterableAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.NotCountableAttribute : System.Attribute {
	public NotCountableAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.NotExpandableAttribute : System.Attribute {
	public NotExpandableAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.NotFilterableAttribute : System.Attribute {
	public NotFilterableAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.NotNavigableAttribute : System.Attribute {
	public NotNavigableAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.NotSortableAttribute : System.Attribute {
	public NotSortableAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.OrderByAttribute : System.Attribute {
	public OrderByAttribute ()
	public OrderByAttribute (string[] properties)

	bool Disabled  { public get; public set; }
	System.Collections.Generic.Dictionary`2[[System.String],[System.Boolean]] OrderByConfigurations  { public get; }
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.PageAttribute : System.Attribute {
	public PageAttribute ()

	int MaxTop  { public get; public set; }
	int PageSize  { public get; public set; }
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.SelectAttribute : System.Attribute {
	public SelectAttribute ()
	public SelectAttribute (string[] properties)

	System.Collections.Generic.Dictionary`2[[System.String],[Microsoft.OData.ModelBuilder.SelectExpandType]] SelectConfigurations  { public get; }
	Microsoft.OData.ModelBuilder.SelectExpandType SelectType  { public get; public set; }
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.SingletonAttribute : System.Attribute {
	public SingletonAttribute ()
}

[
AttributeUsageAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.UnsortableAttribute : System.Attribute {
	public UnsortableAttribute ()
}

public class Microsoft.OData.ModelBuilder.Annotations.QueryableRestrictionsAnnotation {
	public QueryableRestrictionsAnnotation (Microsoft.OData.ModelBuilder.Config.QueryableRestrictions restrictions)

	Microsoft.OData.ModelBuilder.Config.QueryableRestrictions Restrictions  { public get; }
}

public class Microsoft.OData.ModelBuilder.Config.DefaultQuerySettings {
	public DefaultQuerySettings ()

	bool EnableCount  { public get; public set; }
	bool EnableExpand  { public get; public set; }
	bool EnableFilter  { public get; public set; }
	bool EnableOrderBy  { public get; public set; }
	bool EnableSelect  { public get; public set; }
	bool EnableSkipToken  { public get; public set; }
	System.Nullable`1[[System.Int32]] MaxTop  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.Config.ExpandConfiguration {
	public ExpandConfiguration ()

	Microsoft.OData.ModelBuilder.SelectExpandType ExpandType  { public get; public set; }
	int MaxDepth  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.Config.ModelBoundQuerySettings {
	public ModelBoundQuerySettings ()
	public ModelBoundQuerySettings (Microsoft.OData.ModelBuilder.Config.ModelBoundQuerySettings querySettings)

	System.Nullable`1[[System.Boolean]] Countable  { public get; public set; }
	System.Nullable`1[[System.Boolean]] DefaultEnableFilter  { public get; public set; }
	System.Nullable`1[[System.Boolean]] DefaultEnableOrderBy  { public get; public set; }
	System.Nullable`1[[Microsoft.OData.ModelBuilder.SelectExpandType]] DefaultExpandType  { public get; public set; }
	int DefaultMaxDepth  { public get; public set; }
	System.Nullable`1[[Microsoft.OData.ModelBuilder.SelectExpandType]] DefaultSelectType  { public get; public set; }
	System.Collections.Generic.Dictionary`2[[System.String],[Microsoft.OData.ModelBuilder.Config.ExpandConfiguration]] ExpandConfigurations  { public get; }
	System.Collections.Generic.Dictionary`2[[System.String],[System.Boolean]] FilterConfigurations  { public get; }
	System.Nullable`1[[System.Int32]] MaxTop  { public get; public set; }
	System.Collections.Generic.Dictionary`2[[System.String],[System.Boolean]] OrderByConfigurations  { public get; }
	System.Nullable`1[[System.Int32]] PageSize  { public get; public set; }
	System.Collections.Generic.Dictionary`2[[System.String],[Microsoft.OData.ModelBuilder.SelectExpandType]] SelectConfigurations  { public get; }
}

public class Microsoft.OData.ModelBuilder.Config.QueryableRestrictions {
	public QueryableRestrictions ()
	public QueryableRestrictions (Microsoft.OData.ModelBuilder.PropertyConfiguration propertyConfiguration)

	bool AutoExpand  { public get; public set; }
	bool DisableAutoExpandWhenSelectIsPresent  { public get; public set; }
	bool NonFilterable  { public get; public set; }
	bool NotCountable  { public get; public set; }
	bool NotExpandable  { public get; public set; }
	bool NotFilterable  { public get; public set; }
	bool NotNavigable  { public get; public set; }
	bool NotSortable  { public get; public set; }
	bool Unsortable  { public get; public set; }
}

public interface Microsoft.OData.ModelBuilder.Conventions.IODataModelConventionSetBuilder {
	Microsoft.OData.ModelBuilder.Conventions.ODataModelConventionSet Build ()
}

public class Microsoft.OData.ModelBuilder.Conventions.ODataModelConventionSet {
	public ODataModelConventionSet ()
}

public interface Microsoft.OData.ModelBuilder.Vocabularies.IRecord {
	Microsoft.OData.Edm.Vocabularies.EdmRecordExpression ToEdmRecordExpression ()
}

public abstract class Microsoft.OData.ModelBuilder.Vocabularies.VocabularyBuilder`1 {
	public VocabularyBuilder`1 (string termName, T data)

	T Data  { protected get; }
	string TermName  { protected get; }

	public virtual void SetVocabularyAnnotations (Microsoft.OData.Edm.EdmModel model, Microsoft.OData.Edm.Vocabularies.IEdmVocabularyAnnotatable target)
}

public abstract class Microsoft.OData.ModelBuilder.Conventions.Attributes.AttributeConvention : IODataModelConvention {
	protected AttributeConvention (System.Func`2[[System.Attribute],[System.Boolean]] attributeFilter, bool allowMultiple)

	bool AllowMultiple  { public get; }
	System.Func`2[[System.Attribute],[System.Boolean]] AttributeFilter  { public get; }

	public System.Attribute[] GetAttributes (System.Reflection.MemberInfo member)
}

public abstract class Microsoft.OData.ModelBuilder.Conventions.Attributes.PropertyAttributeConvention`1 : Microsoft.OData.ModelBuilder.Conventions.Attributes.AttributeConvention, IODataModelConvention {
	public PropertyAttributeConvention`1 ()
}

public abstract class Microsoft.OData.ModelBuilder.Conventions.Attributes.TypeAttributeConvention`1 : Microsoft.OData.ModelBuilder.Conventions.Attributes.AttributeConvention, IODataModelConvention {
	public TypeAttributeConvention`1 ()
}

public abstract class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.ReadRestrictionsBase {
	public ReadRestrictionsBase ()

	string Description  { public get; public set; }
	string LongDescription  { public get; public set; }
	System.Collections.Generic.List`1[[Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.PermissionType]] Permissions  { public get; }
	System.Nullable`1[[System.Boolean]] Readable  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.DeleteRestrictionsBuilder : Microsoft.OData.ModelBuilder.Vocabularies.VocabularyBuilder`1[[Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.DeleteRestrictionsType]] {
	public DeleteRestrictionsBuilder ()

	public Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.DeleteRestrictionsBuilder HasDescription (string description)
	public Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.DeleteRestrictionsBuilder HasLongDescription (string longDescription)
	public Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.DeleteRestrictionsBuilder HasPermissions (System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.PermissionType]] permissions)
	public Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.DeleteRestrictionsBuilder IsDeletable (bool deletable)
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.DeleteRestrictionsType : IRecord {
	public DeleteRestrictionsType ()

	System.Nullable`1[[System.Boolean]] Deletable  { public get; public set; }
	string Description  { public get; public set; }
	string LongDescription  { public get; public set; }
	System.Collections.Generic.List`1[[Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.PermissionType]] Permissions  { public get; }

	public virtual Microsoft.OData.Edm.Vocabularies.EdmRecordExpression ToEdmRecordExpression ()
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.InsertRestrictionsType {
	public InsertRestrictionsType ()

	string Description  { public get; public set; }
	System.Nullable`1[[System.Boolean]] Insertable  { public get; public set; }
	string LongDescription  { public get; public set; }
	System.Collections.Generic.List`1[[Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.PermissionType]] Permissions  { public get; }
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.OperationRestrictionsType {
	public OperationRestrictionsType ()

	System.Collections.Generic.List`1[[Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.PermissionType]] Permissions  { public get; }
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.PermissionType : IRecord {
	public PermissionType ()

	string SchemeName  { public get; public set; }
	System.Collections.Generic.List`1[[Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.ScopeType]] Scopes  { public get; }

	public virtual Microsoft.OData.Edm.Vocabularies.EdmRecordExpression ToEdmRecordExpression ()
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.ReadByKeyRestrictionsType : Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.ReadRestrictionsBase {
	public ReadByKeyRestrictionsType ()
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.ReadRestrictionsType : Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.ReadRestrictionsBase {
	public ReadRestrictionsType ()

	Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.ReadByKeyRestrictionsType ReadByKeyRestrictions  { public get; public set; }
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.ScopeType : IRecord {
	public ScopeType ()

	string RestrictedProperties  { public get; public set; }
	string Scope  { public get; public set; }

	public virtual Microsoft.OData.Edm.Vocabularies.EdmRecordExpression ToEdmRecordExpression ()
}

public class Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.UpdateRestrictionsType {
	public UpdateRestrictionsType ()

	string Description  { public get; public set; }
	string LongDescription  { public get; public set; }
	System.Collections.Generic.List`1[[Microsoft.OData.ModelBuilder.Vocabularies.Capabilities.PermissionType]] Permissions  { public get; }
	System.Nullable`1[[System.Boolean]] Updatable  { public get; public set; }
	System.Nullable`1[[System.Boolean]] Upsertable  { public get; public set; }
}

