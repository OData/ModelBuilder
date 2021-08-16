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
	InstanceAnnotations = 6
	Navigation = 3
	Primitive = 0
	Untyped = 7
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

public interface Microsoft.OData.ModelBuilder.IODataInstanceAnnotationContainer {
	System.Collections.Generic.IDictionary`2[[System.String],[System.Collections.Generic.IDictionary`2[[System.String],[System.Object]]]] InstanceAnnotations  { public abstract get; }
}

public interface Microsoft.OData.ModelBuilder.IODataModelConvention {
}

public interface Microsoft.OData.ModelBuilder.IRecord {
	Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public abstract class Microsoft.OData.ModelBuilder.NavigationSourceConfiguration {
	protected NavigationSourceConfiguration ()
	protected NavigationSourceConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType, string name)
	protected NavigationSourceConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, System.Type entityClrType, string name)

	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyBindingConfiguration]] Bindings  { public get; }
	System.Type ClrType  { public get; }
	Microsoft.OData.ModelBuilder.EntityTypeConfiguration EntityType  { public virtual get; }
	string Name  { public get; }
	System.Collections.Generic.Dictionary`2[[System.Type],[Microsoft.OData.ModelBuilder.VocabularyTermConfiguration]] VocabularyTermConfigurations  { public get; }

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
	System.Collections.Generic.Dictionary`2[[System.Type],[Microsoft.OData.ModelBuilder.VocabularyTermConfiguration]] VocabularyTermConfigurations  { public get; }

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
	Microsoft.OData.ModelBuilder.Config.QueryConfiguration QueryConfiguration  { public get; public set; }
	System.Type RelatedClrType  { public abstract get; }
	bool Unsortable  { public get; public set; }

	public Microsoft.OData.ModelBuilder.PropertyConfiguration Count ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Count (bool enabled)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Expand ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Expand (Microsoft.OData.ModelBuilder.SelectExpandType expandType)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Expand (int maxDepth)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Expand (string[] properties)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Expand (Microsoft.OData.ModelBuilder.SelectExpandType expandType, int maxDepth)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Expand (Microsoft.OData.ModelBuilder.SelectExpandType expandType, string[] properties)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Expand (int maxDepth, string[] properties)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Expand (int maxDepth, Microsoft.OData.ModelBuilder.SelectExpandType expandType, string[] properties)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Filter ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Filter (bool enabled)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Filter (string[] properties)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Filter (bool enabled, string[] properties)
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
	public Microsoft.OData.ModelBuilder.PropertyConfiguration OrderBy ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration OrderBy (bool enabled)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration OrderBy (string[] properties)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration OrderBy (bool enabled, string[] properties)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Page ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Page (System.Nullable`1[[System.Int32]] maxTopValue, System.Nullable`1[[System.Int32]] pageSizeValue)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Select ()
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Select (Microsoft.OData.ModelBuilder.SelectExpandType selectType)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Select (string[] properties)
	public Microsoft.OData.ModelBuilder.PropertyConfiguration Select (Microsoft.OData.ModelBuilder.SelectExpandType selectType, string[] properties)
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
	bool HasInstanceAnnotations  { public get; }
	System.Collections.ObjectModel.ReadOnlyCollection`1[[System.Reflection.PropertyInfo]] IgnoredProperties  { public get; }
	System.Reflection.PropertyInfo InstanceAnnotationsContainer  { public get; }
	System.Nullable`1[[System.Boolean]] IsAbstract  { public virtual get; public virtual set; }
	bool IsOpen  { public get; }
	Microsoft.OData.Edm.EdmTypeKind Kind  { public abstract get; }
	Microsoft.OData.ModelBuilder.ODataModelBuilder ModelBuilder  { public virtual get; }
	string Name  { public virtual get; public virtual set; }
	string Namespace  { public virtual get; public virtual set; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration]] NavigationProperties  { public virtual get; }
	System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.PropertyConfiguration]] Properties  { public get; }
	Microsoft.OData.ModelBuilder.Config.QueryConfiguration QueryConfiguration  { public get; public set; }
	System.Collections.Generic.IList`1[[System.Reflection.PropertyInfo]] RemovedProperties  { protected get; }

	internal virtual void AbstractImpl ()
	public virtual Microsoft.OData.ModelBuilder.CollectionPropertyConfiguration AddCollectionProperty (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.ComplexPropertyConfiguration AddComplexProperty (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration AddContainedNavigationProperty (System.Reflection.PropertyInfo navigationProperty, Microsoft.OData.Edm.EdmMultiplicity multiplicity)
	public virtual void AddDynamicPropertyDictionary (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.EnumPropertyConfiguration AddEnumProperty (System.Reflection.PropertyInfo propertyInfo)
	public virtual void AddInstanceAnnotationContainer (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.NavigationPropertyConfiguration AddNavigationProperty (System.Reflection.PropertyInfo navigationProperty, Microsoft.OData.Edm.EdmMultiplicity multiplicity)
	public virtual Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration AddProperty (System.Reflection.PropertyInfo propertyInfo)
	public virtual Microsoft.OData.ModelBuilder.UntypedPropertyConfiguration AddUntypedProperty (System.Reflection.PropertyInfo propertyInfo)
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
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Count ()
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Count (bool enabled)
	public Microsoft.OData.ModelBuilder.EnumPropertyConfiguration EnumProperty (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.EnumPropertyConfiguration EnumProperty (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Expand ()
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Expand (Microsoft.OData.ModelBuilder.SelectExpandType expandType)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Expand (int maxDepth)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Expand (string[] properties)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Expand (Microsoft.OData.ModelBuilder.SelectExpandType expandType, int maxDepth)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Expand (Microsoft.OData.ModelBuilder.SelectExpandType expandType, string[] properties)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Expand (int maxDepth, string[] properties)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Expand (int maxDepth, Microsoft.OData.ModelBuilder.SelectExpandType expandType, string[] properties)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Filter ()
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Filter (bool enabled)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Filter (string[] properties)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Filter (bool enabled, string[] properties)
	public void HasDynamicProperties (Expression`1 propertyExpression)
	public void HasInstanceAnnotations (Expression`1 propertyExpression)
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
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 OrderBy ()
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 OrderBy (bool enabled)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 OrderBy (string[] properties)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 OrderBy (bool enabled, string[] properties)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Page ()
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Page (System.Nullable`1[[System.Int32]] maxTopValue, System.Nullable`1[[System.Int32]] pageSizeValue)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.DecimalPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.UntypedPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.LengthPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.LengthPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrecisionPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.DecimalPropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.PrimitivePropertyConfiguration Property (Expression`1 propertyExpression)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Select ()
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Select (Microsoft.OData.ModelBuilder.SelectExpandType selectType)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Select (string[] properties)
	public Microsoft.OData.ModelBuilder.StructuralTypeConfiguration`1 Select (Microsoft.OData.ModelBuilder.SelectExpandType selectType, string[] properties)
}

public abstract class Microsoft.OData.ModelBuilder.VocabularyTermConfiguration : IRecord {
	protected VocabularyTermConfiguration ()

	string TermName  { public abstract get; }

	public virtual void SetVocabularyAnnotations (Microsoft.OData.Edm.EdmModel model, Microsoft.OData.Edm.Vocabularies.IEdmVocabularyAnnotatable target)
	public abstract Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
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
public sealed class Microsoft.OData.ModelBuilder.IODataInstanceAnnotationContainerExtensions {
	[
	ExtensionAttribute(),
	]
	public static void AddPropertyAnnotation (Microsoft.OData.ModelBuilder.IODataInstanceAnnotationContainer container, string propertyName, string annotationName, object value)

	[
	ExtensionAttribute(),
	]
	public static void AddResourceAnnotation (Microsoft.OData.ModelBuilder.IODataInstanceAnnotationContainer container, string annotationName, object value)

	[
	ExtensionAttribute(),
	]
	public static System.Collections.Generic.IDictionary`2[[System.String],[System.Object]] GetPropertyAnnotations (Microsoft.OData.ModelBuilder.IODataInstanceAnnotationContainer container, string propertyName)

	[
	ExtensionAttribute(),
	]
	public static System.Collections.Generic.IDictionary`2[[System.String],[System.Object]] GetResourceAnnotations (Microsoft.OData.ModelBuilder.IODataInstanceAnnotationContainer container)
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

[
ExtensionAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.VocabularyTermConfigurationExtensions {
	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackSupportedConfiguration HasCallbackSupported (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.ChangeTrackingConfiguration HasChangeTracking (NavigationSourceConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.ChangeTrackingConfiguration HasChangeTracking (Microsoft.OData.ModelBuilder.FunctionConfiguration operationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsConfiguration HasCollectionPropertyRestrictions (NavigationSourceConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.ComputeSupportedConfiguration HasComputeSupported (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.CountRestrictionsConfiguration HasCountRestrictions (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.DeepInsertSupportConfiguration HasDeepInsertSupport (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.DeepUpdateSupportConfiguration HasDeepUpdateSupport (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasDeleteRestrictions (NavigationSourceConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.ExpandRestrictionsConfiguration HasExpandRestrictions (NavigationSourceConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.FilterFunctionsConfiguration HasFilterFunctions (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration HasFilterRestrictions (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.IndexableByKeyConfiguration HasIndexableByKey (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasInsertRestrictions (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration HasModificationQueryOptions (Microsoft.OData.ModelBuilder.ActionConfiguration operationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationRestrictionsConfiguration HasNavigationRestrictions (NavigationSourceConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration HasOperationRestrictions (Microsoft.OData.ModelBuilder.OperationConfiguration operationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasReadRestrictions (NavigationSourceConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration HasSearchRestrictions (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration HasSelectSupport (NavigationSourceConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.SkipSupportedConfiguration HasSkipSupported (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration HasSortRestrictions (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.TopSupportedConfiguration HasTopSupported (EntitySetConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasUpdateRestrictions (NavigationSourceConfiguration`1 navigationSource)

	[
	ExtensionAttribute(),
	]
	public static void SetVocabularyConfigurationAnnotations (Microsoft.OData.Edm.EdmModel model, Microsoft.OData.Edm.EdmNavigationSource target, Microsoft.OData.ModelBuilder.NavigationSourceConfiguration navigationSourceConfiguration)

	[
	ExtensionAttribute(),
	]
	public static void SetVocabularyConfigurationAnnotations (Microsoft.OData.Edm.EdmModel model, Microsoft.OData.Edm.EdmOperation target, Microsoft.OData.ModelBuilder.OperationConfiguration operationConfiguration)

	[
	ExtensionAttribute(),
	]
	public static void SetVocabularyConfigurationAnnotations (Microsoft.OData.Edm.EdmModel model, Microsoft.OData.Edm.Vocabularies.IEdmVocabularyAnnotatable target, System.Collections.Generic.IEnumerable`1[[Microsoft.OData.ModelBuilder.VocabularyTermConfiguration]] configurations)
}

public class Microsoft.OData.ModelBuilder.ActionConfiguration : Microsoft.OData.ModelBuilder.OperationConfiguration {
	bool IsSideEffecting  { public virtual get; }
	Microsoft.OData.ModelBuilder.OperationKind Kind  { public virtual get; }

	public Microsoft.OData.ModelBuilder.ActionConfiguration Returns ()
	public Microsoft.OData.ModelBuilder.ActionConfiguration Returns (System.Type clrReturnType)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollection ()
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollection (System.Type clrElementType)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionFromEntitySet (EntitySetConfiguration`1 entitySetConfiguration)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionFromEntitySet (string entitySetName)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionFromEntitySet (System.Type elementEntityType, string entitySetName)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionViaEntitySetPath (string entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionViaEntitySetPath (string[] entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsCollectionViaEntitySetPath (System.Type clrElementEntityType, string entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsEntityViaEntitySetPath (string entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsEntityViaEntitySetPath (string[] entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsEntityViaEntitySetPath (System.Type entityType, string entitySetPath)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsFromEntitySet (EntitySetConfiguration`1 entitySetConfiguration)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsFromEntitySet (string entitySetName)
	public Microsoft.OData.ModelBuilder.ActionConfiguration ReturnsFromEntitySet (System.Type entityType, string entitySetName)
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

public class Microsoft.OData.ModelBuilder.DefaultAssemblyResolver : IAssemblyResolver {
	public DefaultAssemblyResolver ()

	System.Collections.Generic.IEnumerable`1[[System.Reflection.Assembly]] Assemblies  { public virtual get; }
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
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollection (System.Type clrElementType)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollectionFromEntitySet (string entitySetName)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollectionFromEntitySet (System.Type elementEntityType, string entitySetName)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollectionViaEntitySetPath (string entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollectionViaEntitySetPath (string[] entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsCollectionViaEntitySetPath (System.Type clrElementEntityType, string entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsEntityViaEntitySetPath (string entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsEntityViaEntitySetPath (string[] entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsEntityViaEntitySetPath (System.Type entityType, string entitySetPath)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsFromEntitySet (string entitySetName)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration ReturnsFromEntitySet (System.Type entityType, string entitySetName)
	public Microsoft.OData.ModelBuilder.FunctionConfiguration SetBindingParameter (string name, Microsoft.OData.ModelBuilder.IEdmTypeConfiguration bindingParameterType)
}

public class Microsoft.OData.ModelBuilder.InstanceAnnotationContainerAnnotation {
	public InstanceAnnotationContainerAnnotation (System.Reflection.PropertyInfo propertyInfo)

	System.Reflection.PropertyInfo PropertyInfo  { public get; }
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

public class Microsoft.OData.ModelBuilder.ODataInstanceAnnotationContainer : IODataInstanceAnnotationContainer {
	public ODataInstanceAnnotationContainer ()

	System.Collections.Generic.IDictionary`2[[System.String],[System.Collections.Generic.IDictionary`2[[System.String],[System.Object]]]] InstanceAnnotations  { public virtual get; }
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

public class Microsoft.OData.ModelBuilder.OperationTitleAnnotation {
	public OperationTitleAnnotation (string title)

	string Title  { public get; }
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

public class Microsoft.OData.ModelBuilder.ReturnedEntitySetAnnotation {
	public ReturnedEntitySetAnnotation (string entitySetName)

	string EntitySetName  { public get; }
}

public class Microsoft.OData.ModelBuilder.SingletonConfiguration : Microsoft.OData.ModelBuilder.NavigationSourceConfiguration {
	public SingletonConfiguration ()
	public SingletonConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, Microsoft.OData.ModelBuilder.EntityTypeConfiguration entityType, string name)
	public SingletonConfiguration (Microsoft.OData.ModelBuilder.ODataModelBuilder modelBuilder, System.Type entityClrType, string name)
}

public class Microsoft.OData.ModelBuilder.SingletonConfiguration`1 : NavigationSourceConfiguration`1 {
}

public class Microsoft.OData.ModelBuilder.UntypedPropertyConfiguration : Microsoft.OData.ModelBuilder.StructuralPropertyConfiguration {
	public UntypedPropertyConfiguration (System.Reflection.PropertyInfo property, Microsoft.OData.ModelBuilder.StructuralTypeConfiguration declaringType)

	string DefaultValueString  { public get; public set; }
	Microsoft.OData.ModelBuilder.PropertyKind Kind  { public virtual get; }
	System.Type RelatedClrType  { public virtual get; }

	public Microsoft.OData.ModelBuilder.UntypedPropertyConfiguration IsNullable ()
	public Microsoft.OData.ModelBuilder.UntypedPropertyConfiguration IsRequired ()
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
	public ExpandAttribute (string[] properties)

	System.Collections.Generic.Dictionary`2[[System.String],[Microsoft.OData.ModelBuilder.Config.ExpandConfiguration]] ExpandConfigurations  { public get; }
	Microsoft.OData.ModelBuilder.SelectExpandType ExpandType  { public get; public set; }
	int MaxDepth  { public get; public set; }
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

[
ExtensionAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.Annotations.EdmAnnotationExtensions {
	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.ClrEnumMemberAnnotation GetClrEnumMemberAnnotation (Microsoft.OData.Edm.IEdmModel edmModel, Microsoft.OData.Edm.IEdmEnumType enumType)

	[
	ExtensionAttribute(),
	]
	public static string GetClrPropertyName (Microsoft.OData.Edm.IEdmModel edmModel, Microsoft.OData.Edm.IEdmProperty edmProperty)

	[
	ExtensionAttribute(),
	]
	public static System.Reflection.PropertyInfo GetDynamicPropertyDictionary (Microsoft.OData.Edm.IEdmModel edmModel, Microsoft.OData.Edm.IEdmStructuredType edmType)

	[
	ExtensionAttribute(),
	]
	public static void SetClrType (Microsoft.OData.Edm.IEdmModel edmModel, Microsoft.OData.Edm.IEdmStructuredType structuredType)

	[
	ExtensionAttribute(),
	]
	public static void SetClrType (Microsoft.OData.Edm.IEdmModel edmModel, Microsoft.OData.Edm.IEdmStructuredType structuredType, System.Type clrType)
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

public class Microsoft.OData.ModelBuilder.Config.QueryConfiguration {
	public QueryConfiguration ()

	Microsoft.OData.ModelBuilder.Config.ModelBoundQuerySettings ModelBoundQuerySettings  { public get; public set; }

	public virtual void SetCount (bool enableCount)
	public virtual void SetExpand (System.Collections.Generic.IEnumerable`1[[System.String]] properties, System.Nullable`1[[System.Int32]] maxDepth, Microsoft.OData.ModelBuilder.SelectExpandType expandType)
	public virtual void SetFilter (System.Collections.Generic.IEnumerable`1[[System.String]] properties, bool enableFilter)
	public virtual void SetMaxTop (System.Nullable`1[[System.Int32]] maxTop)
	public virtual void SetOrderBy (System.Collections.Generic.IEnumerable`1[[System.String]] properties, bool enableOrderBy)
	public virtual void SetPageSize (System.Nullable`1[[System.Int32]] pageSize)
	public virtual void SetSelect (System.Collections.Generic.IEnumerable`1[[System.String]] properties, Microsoft.OData.ModelBuilder.SelectExpandType selectType)
}

public interface Microsoft.OData.ModelBuilder.Conventions.IODataModelConventionSetBuilder {
	Microsoft.OData.ModelBuilder.Conventions.ODataModelConventionSet Build ()
}

public class Microsoft.OData.ModelBuilder.Conventions.ODataModelConventionSet {
	public ODataModelConventionSet ()
}

[
ExtensionAttribute(),
]
public sealed class Microsoft.OData.ModelBuilder.Vocabularies.VocabularyTermConfigurationShortcutsExtensions {
	[
	ExtensionAttribute(),
	]
	public static Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration HasScopes (Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration permissionTypeConfiguration, string[] scopeNames)
}

public enum Microsoft.OData.ModelBuilder.Capabilities.V1.ConformanceLevelType : int {
	Advanced = 2
	Intermediate = 1
	Minimal = 0
}

[
FlagsAttribute(),
]
public enum Microsoft.OData.ModelBuilder.Capabilities.V1.IsolationLevel : int {
	Snapshot = 0
}

public enum Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationType : int {
	None = 2
	Recursive = 0
	Single = 1
}

[
FlagsAttribute(),
]
public enum Microsoft.OData.ModelBuilder.Capabilities.V1.SearchExpressions : int {
	AND = 1
	group = 5
	none = 0
	NOT = 3
	OR = 2
	phrase = 4
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.AcceptableEncodingsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public AcceptableEncodingsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.AcceptableEncodingsConfiguration HasAcceptableEncodings (string[] acceptableEncodings)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.AnnotationValuesInQuerySupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public AnnotationValuesInQuerySupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.AnnotationValuesInQuerySupportedConfiguration IsAnnotationValuesInQuerySupported (bool annotationValuesInQuerySupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.AsynchronousRequestsSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public AsynchronousRequestsSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.AsynchronousRequestsSupportedConfiguration IsAsynchronousRequestsSupported (bool asynchronousRequestsSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.BatchContinueOnErrorSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public BatchContinueOnErrorSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchContinueOnErrorSupportedConfiguration IsBatchContinueOnErrorSupported (bool batchContinueOnErrorSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public BatchSupportConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportConfiguration HasSupportedFormats (string[] supportedFormats)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportConfiguration IsContinueOnErrorSupported (bool continueOnErrorSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportConfiguration IsEtagReferencesSupported (bool etagReferencesSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportConfiguration IsReferencesAcrossChangeSetsSupported (bool referencesAcrossChangeSetsSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportConfiguration IsReferencesInRequestBodiesSupported (bool referencesInRequestBodiesSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportConfiguration IsRequestDependencyConditionsSupported (bool requestDependencyConditionsSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportConfiguration IsSupported (bool supported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public BatchSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.BatchSupportedConfiguration IsBatchSupported (bool batchSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackProtocolConfiguration : IRecord {
	public CallbackProtocolConfiguration ()

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackProtocolConfiguration HasDocumentationUrl (string documentationUrl)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackProtocolConfiguration HasId (string id)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackProtocolConfiguration HasUrlTemplate (string urlTemplate)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public CallbackSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackSupportedConfiguration HasCallbackProtocols (Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackProtocolConfiguration[] callbackProtocols)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackSupportedConfiguration HasCallbackProtocols (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackProtocolConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CallbackProtocolConfiguration]] callbackProtocolsConfiguration)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.ChangeTrackingConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public ChangeTrackingConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.ChangeTrackingConfiguration HasExpandableProperties (Microsoft.OData.Edm.Vocabularies.EdmNavigationPropertyPathExpression[] expandableProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ChangeTrackingConfiguration HasFilterableProperties (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression[] filterableProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ChangeTrackingConfiguration IsSupported (bool supported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public CollectionPropertyRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsConfiguration HasCollectionPropertyRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration[] collectionPropertyRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsConfiguration HasCollectionPropertyRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration]] collectionPropertyRestrictionsConfiguration)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration : IRecord {
	public CollectionPropertyRestrictionsTypeConfiguration ()

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasCollectionProperty (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression collectionProperty)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasFilterFunctions (string[] filterFunctions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasFilterRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration filterRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasFilterRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration]] filterRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasSearchRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration searchRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasSearchRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration]] searchRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasSelectSupport (Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration selectSupport)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasSelectSupport (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration]] selectSupportConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasSortRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration sortRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration HasSortRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration]] sortRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration IsDeletable (bool deletable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration IsInsertable (bool insertable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration IsSkipSupported (bool skipSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration IsTopSupported (bool topSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CollectionPropertyRestrictionsTypeConfiguration IsUpdatable (bool updatable)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.ComputeSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public ComputeSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.ComputeSupportedConfiguration IsComputeSupported (bool computeSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.ConformanceLevelConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public ConformanceLevelConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.ConformanceLevelConfiguration HasConformanceLevel (Microsoft.OData.ModelBuilder.Capabilities.V1.ConformanceLevelType conformanceLevel)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CountRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public CountRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CountRestrictionsConfiguration HasNonCountableNavigationProperties (Microsoft.OData.Edm.Vocabularies.EdmNavigationPropertyPathExpression[] nonCountableNavigationProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CountRestrictionsConfiguration HasNonCountableProperties (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression[] nonCountableProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CountRestrictionsConfiguration IsCountable (bool countable)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CrossJoinSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public CrossJoinSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CrossJoinSupportedConfiguration IsCrossJoinSupported (bool crossJoinSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CustomHeadersConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public CustomHeadersConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomHeadersConfiguration HasCustomHeaders (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customHeaders)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomHeadersConfiguration HasCustomHeaders (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customHeadersConfiguration)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration : IRecord {
	public CustomParameterConfiguration ()

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration HasDescription (string description)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration HasDocumentationURL (string documentationURL)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration HasExampleValues (Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration[] exampleValues)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration HasExampleValues (System.Func`2[[Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration],[Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration]] exampleValuesConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration HasName (string name)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration IsRequired (bool required)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.CustomQueryOptionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public CustomQueryOptionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomQueryOptionsConfiguration HasCustomQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customQueryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.CustomQueryOptionsConfiguration HasCustomQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customQueryOptionsConfiguration)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.DeepInsertSupportConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public DeepInsertSupportConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeepInsertSupportConfiguration IsContentIDSupported (bool contentIDSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeepInsertSupportConfiguration IsSupported (bool supported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.DeepUpdateSupportConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public DeepUpdateSupportConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeepUpdateSupportConfiguration IsContentIDSupported (bool contentIDSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeepUpdateSupportConfiguration IsSupported (bool supported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public DeleteRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasCustomHeaders (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customHeaders)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasCustomHeaders (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customHeadersConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasCustomQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customQueryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasCustomQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customQueryOptionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasDescription (string description)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasLongDescription (string longDescription)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasMaxLevels (int maxLevels)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasNonDeletableNavigationProperties (Microsoft.OData.Edm.Vocabularies.EdmNavigationPropertyPathExpression[] nonDeletableNavigationProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasPermissions (Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration[] permissions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration HasPermissions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration]] permissionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration IsDeletable (bool deletable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration IsFilterSegmentSupported (bool filterSegmentSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration IsTypecastSegmentSupported (bool typecastSegmentSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.ExpandRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public ExpandRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.ExpandRestrictionsConfiguration HasMaxLevels (int maxLevels)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ExpandRestrictionsConfiguration HasNonExpandableProperties (Microsoft.OData.Edm.Vocabularies.EdmNavigationPropertyPathExpression[] nonExpandableProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ExpandRestrictionsConfiguration IsExpandable (bool expandable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ExpandRestrictionsConfiguration IsStreamsExpandable (bool streamsExpandable)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.FilterExpressionRestrictionTypeConfiguration : IRecord {
	public FilterExpressionRestrictionTypeConfiguration ()

	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterExpressionRestrictionTypeConfiguration HasAllowedExpressions (string allowedExpressions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterExpressionRestrictionTypeConfiguration HasProperty (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression property)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.FilterFunctionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public FilterFunctionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterFunctionsConfiguration HasFilterFunctions (string[] filterFunctions)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public FilterRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration HasFilterExpressionRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.FilterExpressionRestrictionTypeConfiguration[] filterExpressionRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration HasFilterExpressionRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.FilterExpressionRestrictionTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.FilterExpressionRestrictionTypeConfiguration]] filterExpressionRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration HasMaxLevels (int maxLevels)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration HasNonFilterableProperties (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression[] nonFilterableProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration HasRequiredProperties (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression[] requiredProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration IsFilterable (bool filterable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration IsRequiresFilter (bool requiresFilter)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.IndexableByKeyConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public IndexableByKeyConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.IndexableByKeyConfiguration IsIndexableByKey (bool indexableByKey)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public InsertRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasCustomHeaders (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customHeaders)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasCustomHeaders (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customHeadersConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasCustomQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customQueryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasCustomQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customQueryOptionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasDescription (string description)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasLongDescription (string longDescription)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasMaxLevels (int maxLevels)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasNonInsertableNavigationProperties (Microsoft.OData.Edm.Vocabularies.EdmNavigationPropertyPathExpression[] nonInsertableNavigationProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasNonInsertableProperties (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression[] nonInsertableProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasPermissions (Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration[] permissions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasPermissions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration]] permissionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration queryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration HasQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration]] queryOptionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration IsInsertable (bool insertable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration IsTypecastSegmentSupported (bool typecastSegmentSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.IsolationSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public IsolationSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.IsolationSupportedConfiguration HasIsolationSupported (Microsoft.OData.ModelBuilder.Capabilities.V1.IsolationLevel isolationSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.KeyAsSegmentSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public KeyAsSegmentSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.KeyAsSegmentSupportedConfiguration IsKeyAsSegmentSupported (bool keyAsSegmentSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.MediaLocationUpdateSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public MediaLocationUpdateSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.MediaLocationUpdateSupportedConfiguration IsMediaLocationUpdateSupported (bool mediaLocationUpdateSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public ModificationQueryOptionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration IsComputeSupported (bool computeSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration IsExpandSupported (bool expandSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration IsFilterSupported (bool filterSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration IsSearchSupported (bool searchSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration IsSelectSupported (bool selectSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration IsSortSupported (bool sortSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration : IRecord {
	public NavigationPropertyRestrictionConfiguration ()

	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasDeepInsertSupport (Microsoft.OData.ModelBuilder.Capabilities.V1.DeepInsertSupportConfiguration deepInsertSupport)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasDeepInsertSupport (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.DeepInsertSupportConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.DeepInsertSupportConfiguration]] deepInsertSupportConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasDeepUpdateSupport (Microsoft.OData.ModelBuilder.Capabilities.V1.DeepUpdateSupportConfiguration deepUpdateSupport)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasDeepUpdateSupport (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.DeepUpdateSupportConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.DeepUpdateSupportConfiguration]] deepUpdateSupportConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasDeleteRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration deleteRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasDeleteRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.DeleteRestrictionsConfiguration]] deleteRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasFilterFunctions (string[] filterFunctions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasFilterRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration filterRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasFilterRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.FilterRestrictionsConfiguration]] filterRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasInsertRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration insertRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasInsertRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.InsertRestrictionsConfiguration]] insertRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasNavigability (Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationType navigability)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasNavigationProperty (Microsoft.OData.Edm.Vocabularies.EdmNavigationPropertyPathExpression navigationProperty)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasReadRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration readRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasReadRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration]] readRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasSearchRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration searchRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasSearchRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration]] searchRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasSelectSupport (Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration selectSupport)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasSelectSupport (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration]] selectSupportConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasSortRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration sortRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasSortRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration]] sortRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasUpdateRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration updateRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration HasUpdateRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration]] updateRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration IsIndexableByKey (bool indexableByKey)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration IsOptimisticConcurrencyControl (bool optimisticConcurrencyControl)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration IsSkipSupported (bool skipSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration IsTopSupported (bool topSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public NavigationRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationRestrictionsConfiguration HasNavigability (Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationType navigability)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationRestrictionsConfiguration HasRestrictedProperties (Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration[] restrictedProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationRestrictionsConfiguration HasRestrictedProperties (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.NavigationPropertyRestrictionConfiguration]] restrictedPropertiesConfiguration)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public OperationRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration HasCustomHeaders (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customHeaders)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration HasCustomHeaders (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customHeadersConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration HasCustomQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customQueryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration HasCustomQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customQueryOptionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration HasPermissions (Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration[] permissions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration HasPermissions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration]] permissionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.OperationRestrictionsConfiguration IsFilterSegmentSupported (bool filterSegmentSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration : IRecord {
	public PermissionTypeConfiguration ()

	public Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration HasSchemeName (string schemeName)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration HasScopes (Microsoft.OData.ModelBuilder.Capabilities.V1.ScopeTypeConfiguration[] scopes)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration HasScopes (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.ScopeTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.ScopeTypeConfiguration]] scopesConfiguration)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.QuerySegmentSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public QuerySegmentSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.QuerySegmentSupportedConfiguration IsQuerySegmentSupported (bool querySegmentSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration : IRecord {
	public ReadByKeyRestrictionsTypeConfiguration ()

	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration HasCustomHeaders (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customHeaders)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration HasCustomHeaders (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customHeadersConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration HasCustomQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customQueryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration HasCustomQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customQueryOptionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration HasDescription (string description)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration HasLongDescription (string longDescription)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration HasPermissions (Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration[] permissions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration HasPermissions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration]] permissionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration IsReadable (bool readable)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public ReadRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasCustomHeaders (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customHeaders)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasCustomHeaders (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customHeadersConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasCustomQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customQueryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasCustomQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customQueryOptionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasDescription (string description)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasLongDescription (string longDescription)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasPermissions (Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration[] permissions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasPermissions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration]] permissionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasReadByKeyRestrictions (Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration readByKeyRestrictions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration HasReadByKeyRestrictions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.ReadByKeyRestrictionsTypeConfiguration]] readByKeyRestrictionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ReadRestrictionsConfiguration IsReadable (bool readable)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.ScopeTypeConfiguration : IRecord {
	public ScopeTypeConfiguration ()

	public Microsoft.OData.ModelBuilder.Capabilities.V1.ScopeTypeConfiguration HasRestrictedProperties (string restrictedProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.ScopeTypeConfiguration HasScope (string scope)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public SearchRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration HasUnsupportedExpressions (Microsoft.OData.ModelBuilder.Capabilities.V1.SearchExpressions unsupportedExpressions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SearchRestrictionsConfiguration IsSearchable (bool searchable)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public SelectSupportConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsComputeSupported (bool computeSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsCountable (bool countable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsExpandable (bool expandable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsFilterable (bool filterable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsInstanceAnnotationsSupported (bool instanceAnnotationsSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsSearchable (bool searchable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsSkipSupported (bool skipSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsSortable (bool sortable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsSupported (bool supported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SelectSupportConfiguration IsTopSupported (bool topSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.SkipSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public SkipSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.SkipSupportedConfiguration IsSkipSupported (bool skipSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public SortRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration HasAscendingOnlyProperties (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression[] ascendingOnlyProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration HasDescendingOnlyProperties (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression[] descendingOnlyProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration HasNonSortableProperties (Microsoft.OData.Edm.Vocabularies.EdmPropertyPathExpression[] nonSortableProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.SortRestrictionsConfiguration IsSortable (bool sortable)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.SupportedFormatsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public SupportedFormatsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.SupportedFormatsConfiguration HasSupportedFormats (string[] supportedFormats)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.SupportedMetadataFormatsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public SupportedMetadataFormatsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.SupportedMetadataFormatsConfiguration HasSupportedMetadataFormats (string[] supportedMetadataFormats)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.TopSupportedConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public TopSupportedConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.TopSupportedConfiguration IsTopSupported (bool topSupported)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

public class Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration : Microsoft.OData.ModelBuilder.VocabularyTermConfiguration, IRecord {
	public UpdateRestrictionsConfiguration ()

	string TermName  { public virtual get; }

	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasCustomHeaders (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customHeaders)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasCustomHeaders (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customHeadersConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasCustomQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration[] customQueryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasCustomQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.CustomParameterConfiguration]] customQueryOptionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasDescription (string description)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasLongDescription (string longDescription)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasMaxLevels (int maxLevels)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasNonUpdatableNavigationProperties (Microsoft.OData.Edm.Vocabularies.EdmNavigationPropertyPathExpression[] nonUpdatableNavigationProperties)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasPermissions (Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration[] permissions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasPermissions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.PermissionTypeConfiguration]] permissionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasQueryOptions (Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration queryOptions)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration HasQueryOptions (System.Func`2[[Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration],[Microsoft.OData.ModelBuilder.Capabilities.V1.ModificationQueryOptionsConfiguration]] queryOptionsConfiguration)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration IsDeltaUpdateSupported (bool deltaUpdateSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration IsFilterSegmentSupported (bool filterSegmentSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration IsTypecastSegmentSupported (bool typecastSegmentSupported)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration IsUpdatable (bool updatable)
	public Microsoft.OData.ModelBuilder.Capabilities.V1.UpdateRestrictionsConfiguration IsUpsertable (bool upsertable)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
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

public class Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration : IRecord {
	public PrimitiveExampleValueConfiguration ()

	public Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration HasDescription (string description)
	public Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration HasValue (object value)
	public virtual Microsoft.OData.Edm.IEdmExpression ToEdmExpression ()
}

