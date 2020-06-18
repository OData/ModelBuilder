// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Capabilities.V1
{
	/// <summary>
	/// Restrictions on /$count path suffix and $count=true system query option
	/// </summary>
	public partial class CountRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private bool? _countable;
		private readonly HashSet<EdmPropertyPathExpression> _nonCountableProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmNavigationPropertyPathExpression> _nonCountableNavigationProperties = new HashSet<EdmNavigationPropertyPathExpression>();

        /// <summary>
        /// Creates a new instance of <see cref="CountRestrictionsConfiguration"/>
        /// </summary>
		public CountRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.CountRestrictions")
		{
		}

		/// <summary>
		/// Entities can be counted
		/// </summary>
		/// <param name="countable">The value to set</param>
		/// <returns><see cref="CountRestrictionsConfiguration"/></returns>
		public CountRestrictionsConfiguration IsCountable(bool countable)
		{
			_countable = countable;
			return this;
		}

		/// <summary>
		/// These collection properties do not allow /$count segments
		/// </summary>
		/// <param name="nonCountableProperties">The value(s) to set</param>
		/// <returns><see cref="CountRestrictionsConfiguration"/></returns>
		public CountRestrictionsConfiguration AddNonCountableProperties(params EdmPropertyPathExpression[] nonCountableProperties)
		{
			foreach (var item in nonCountableProperties)
			{
				_ = _nonCountableProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// These navigation properties do not allow /$count segments
		/// </summary>
		/// <param name="nonCountableNavigationProperties">The value(s) to set</param>
		/// <returns><see cref="CountRestrictionsConfiguration"/></returns>
		public CountRestrictionsConfiguration AddNonCountableNavigationProperties(params EdmNavigationPropertyPathExpression[] nonCountableNavigationProperties)
		{
			foreach (var item in nonCountableNavigationProperties)
			{
				_ = _nonCountableNavigationProperties.Add(item);
			}

			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_countable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Countable", new EdmBooleanConstant(_countable.Value)));
			}

			if (_nonCountableProperties.Any())
			{
				var collection = _nonCountableProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("NonCountableProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_nonCountableNavigationProperties.Any())
			{
				var collection = _nonCountableNavigationProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("NonCountableNavigationProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
