﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.3.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using EntityModel;
using EntityModel.FactoryClasses;
using EntityModel.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace EntityModel.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: SpecificItem. </summary>
	public partial class SpecificItemRelations : DomainItemRelations
	{
		/// <summary>CTor</summary>
		public SpecificItemRelations()
		{
		}

		/// <summary>Gets all relations of the SpecificItemEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public override List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = base.GetAllRelations();
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between SpecificItemEntity and CollectionEntity over the m:1 relation they have, using the relation between the fields:
		/// SpecificItem.CollectionId - Collection.Id
		/// </summary>
		public override IEntityRelation CollectionEntityUsingCollectionId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Collection", false);
				relation.AddEntityFieldPair(CollectionFields.Id, SpecificItemFields.CollectionId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("CollectionEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SpecificItemEntity", true);
				return relation;
			}
		}

		/// <summary>Returns a new IEntityRelation object, between SpecificItemEntity and DomainItemEntity over the 1:1 relation they have, which is used to build a target per entity hierarchy</summary>
		internal IEntityRelation RelationToSuperTypeDomainItemEntity
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToOne, false);
				relation.AddEntityFieldPair(DomainItemFields.Id, SpecificItemFields.Id);
				relation.IsHierarchyRelation=true;
				return relation;
			}
		}

		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with the subtype with the specified name</summary>
		/// <param name="subTypeEntityName">name of direct subtype which is a subtype of the current entity through the relation to return.</param>
		/// <returns>relation which makes the current entity a supertype of the subtype entity with the name specified, or null if not applicable/found</returns>
		public override IEntityRelation GetSubTypeRelation(string subTypeEntityName)
		{
			return null;
		}
		
		/// <summary>Returns the relation object the entity, to which this relation factory belongs, has with its supertype, if applicable.</summary>
		/// <returns>relation which makes the current entity a subtype of its supertype entity or null if not applicable/found</returns>
		public override IEntityRelation GetSuperTypeRelation()
		{
			return this.RelationToSuperTypeDomainItemEntity;
		}

		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticSpecificItemRelations
	{
		internal static readonly IEntityRelation CollectionEntityUsingCollectionIdStatic = new SpecificItemRelations().CollectionEntityUsingCollectionId;

		/// <summary>CTor</summary>
		static StaticSpecificItemRelations()
		{
		}
	}
}
