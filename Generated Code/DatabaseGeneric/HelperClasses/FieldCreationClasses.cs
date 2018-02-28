﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.3.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;
using EntityModel.FactoryClasses;
using EntityModel;

namespace EntityModel.HelperClasses
{
	/// <summary>Field Creation Class for entity PersonEntity</summary>
	public partial class PersonFields
	{
		/// <summary>Creates a new PersonEntity.CollectionId field instance</summary>
		public static EntityField2 CollectionId
		{
			get { return (EntityField2)EntityFieldFactory.Create(PersonFieldIndex.CollectionId);}
		}
		/// <summary>Creates a new PersonEntity.Id field instance</summary>
		public static EntityField2 Id_Actor
		{
			get { return (EntityField2)EntityFieldFactory.Create(PersonFieldIndex.Id_Actor);}
		}
		/// <summary>Creates a new PersonEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(PersonFieldIndex.Id);}
		}
		/// <summary>Creates a new PersonEntity.Firstname field instance</summary>
		public static EntityField2 Firstname
		{
			get { return (EntityField2)EntityFieldFactory.Create(PersonFieldIndex.Firstname);}
		}
		/// <summary>Creates a new PersonEntity.Lastname field instance</summary>
		public static EntityField2 Lastname
		{
			get { return (EntityField2)EntityFieldFactory.Create(PersonFieldIndex.Lastname);}
		}
	}

	/// <summary>Field Creation Class for entity ActorEntity</summary>
	public partial class ActorFields
	{
		/// <summary>Creates a new ActorEntity.CollectionId field instance</summary>
		public static EntityField2 CollectionId
		{
			get { return (EntityField2)EntityFieldFactory.Create(ActorFieldIndex.CollectionId);}
		}
		/// <summary>Creates a new ActorEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(ActorFieldIndex.Id);}
		}
	}

	/// <summary>Field Creation Class for entity ActorIncidentEntity</summary>
	public partial class ActorIncidentFields
	{
		/// <summary>Creates a new ActorIncidentEntity.ActorId field instance</summary>
		public static EntityField2 ActorId
		{
			get { return (EntityField2)EntityFieldFactory.Create(ActorIncidentFieldIndex.ActorId);}
		}
		/// <summary>Creates a new ActorIncidentEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(ActorIncidentFieldIndex.Id);}
		}
		/// <summary>Creates a new ActorIncidentEntity.IncidentId field instance</summary>
		public static EntityField2 IncidentId
		{
			get { return (EntityField2)EntityFieldFactory.Create(ActorIncidentFieldIndex.IncidentId);}
		}
	}

	/// <summary>Field Creation Class for entity CollectionEntity</summary>
	public partial class CollectionFields
	{
		/// <summary>Creates a new CollectionEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(CollectionFieldIndex.Id);}
		}
		/// <summary>Creates a new CollectionEntity.Name field instance</summary>
		public static EntityField2 Name
		{
			get { return (EntityField2)EntityFieldFactory.Create(CollectionFieldIndex.Name);}
		}
	}

	/// <summary>Field Creation Class for entity IncidentEntity</summary>
	public partial class IncidentFields
	{
		/// <summary>Creates a new IncidentEntity.CollectionId field instance</summary>
		public static EntityField2 CollectionId
		{
			get { return (EntityField2)EntityFieldFactory.Create(IncidentFieldIndex.CollectionId);}
		}
		/// <summary>Creates a new IncidentEntity.Grouping field instance</summary>
		public static EntityField2 Grouping
		{
			get { return (EntityField2)EntityFieldFactory.Create(IncidentFieldIndex.Grouping);}
		}
		/// <summary>Creates a new IncidentEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(IncidentFieldIndex.Id);}
		}
		/// <summary>Creates a new IncidentEntity.ItemId field instance</summary>
		public static EntityField2 ItemId
		{
			get { return (EntityField2)EntityFieldFactory.Create(IncidentFieldIndex.ItemId);}
		}
	}

	/// <summary>Field Creation Class for entity ItemEntity</summary>
	public partial class ItemFields
	{
		/// <summary>Creates a new ItemEntity.CollectionId field instance</summary>
		public static EntityField2 CollectionId
		{
			get { return (EntityField2)EntityFieldFactory.Create(ItemFieldIndex.CollectionId);}
		}
		/// <summary>Creates a new ItemEntity.Description field instance</summary>
		public static EntityField2 Description
		{
			get { return (EntityField2)EntityFieldFactory.Create(ItemFieldIndex.Description);}
		}
		/// <summary>Creates a new ItemEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(ItemFieldIndex.Id);}
		}
	}

	/// <summary>Field Creation Class for entity DomainItemEntity</summary>
	public partial class DomainItemFields
	{
		/// <summary>Creates a new DomainItemEntity.CollectionId field instance</summary>
		public static EntityField2 CollectionId
		{
			get { return (EntityField2)EntityFieldFactory.Create(DomainItemFieldIndex.CollectionId);}
		}
		/// <summary>Creates a new DomainItemEntity.Description field instance</summary>
		public static EntityField2 Description
		{
			get { return (EntityField2)EntityFieldFactory.Create(DomainItemFieldIndex.Description);}
		}
		/// <summary>Creates a new DomainItemEntity.Id field instance</summary>
		public static EntityField2 Id_Item
		{
			get { return (EntityField2)EntityFieldFactory.Create(DomainItemFieldIndex.Id_Item);}
		}
		/// <summary>Creates a new DomainItemEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(DomainItemFieldIndex.Id);}
		}
		/// <summary>Creates a new DomainItemEntity.OldItemId field instance</summary>
		public static EntityField2 OldItemId
		{
			get { return (EntityField2)EntityFieldFactory.Create(DomainItemFieldIndex.OldItemId);}
		}
	}

	/// <summary>Field Creation Class for entity SpecificItemEntity</summary>
	public partial class SpecificItemFields
	{
		/// <summary>Creates a new SpecificItemEntity.CollectionId field instance</summary>
		public static EntityField2 CollectionId
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecificItemFieldIndex.CollectionId);}
		}
		/// <summary>Creates a new SpecificItemEntity.Description field instance</summary>
		public static EntityField2 Description
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecificItemFieldIndex.Description);}
		}
		/// <summary>Creates a new SpecificItemEntity.Id field instance</summary>
		public static EntityField2 Id_Item
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecificItemFieldIndex.Id_Item);}
		}
		/// <summary>Creates a new SpecificItemEntity.Id field instance</summary>
		public static EntityField2 Id_DomainItem
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecificItemFieldIndex.Id_DomainItem);}
		}
		/// <summary>Creates a new SpecificItemEntity.OldItemId field instance</summary>
		public static EntityField2 OldItemId
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecificItemFieldIndex.OldItemId);}
		}
		/// <summary>Creates a new SpecificItemEntity.Id field instance</summary>
		public static EntityField2 Id
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecificItemFieldIndex.Id);}
		}
		/// <summary>Creates a new SpecificItemEntity.Note field instance</summary>
		public static EntityField2 Note
		{
			get { return (EntityField2)EntityFieldFactory.Create(SpecificItemFieldIndex.Note);}
		}
	}
	

}