﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.3.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto.Persistence
{
	/// <summary>Static class for (extension) methods for fetching and projecting instances of Dto.DtoClasses.ActorPersonDto from / to the entity model.</summary>
	public static partial class ActorPersonDtoPersistence
	{
		#region Statics
		private static readonly System.Linq.Expressions.Expression<Func<EntityModel.EntityClasses.PersonEntity, Dto.DtoClasses.ActorPersonDto>> _projectorExpression = CreateProjectionFunc();
		private static readonly Func<EntityModel.EntityClasses.PersonEntity, Dto.DtoClasses.ActorPersonDto> _compiledProjector = CreateProjectionFunc().Compile();
		#endregion	
	
		/// <summary>Empty static ctor for triggering initialization of static members in a thread-safe manner</summary>
		static ActorPersonDtoPersistence()
		{
		}
	
		/// <summary>Extension method which produces a projection to Dto.DtoClasses.ActorPersonDto which instances are projected from the 
		/// results of the specified baseQuery, which returns EntityModel.EntityClasses.PersonEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <returns>IQueryable to retrieve Dto.DtoClasses.ActorPersonDto instances</returns>
		public static IQueryable<Dto.DtoClasses.ActorPersonDto> ProjectToActorPersonDto(this IQueryable<EntityModel.EntityClasses.PersonEntity> baseQuery)
		{
			return baseQuery.Select(_projectorExpression);
		}
		
		
		/// <summary>Extension method which produces a projection to Dto.DtoClasses.ActorPersonDto which instances are projected from the
		/// EntityModel.EntityClasses.PersonEntity entity instance specified, the root entity of the derived element returned by this method.</summary>
		/// <param name="entity">The entity to project from.</param>
		/// <returns>EntityModel.EntityClasses.PersonEntity instance created from the specified entity instance</returns>
		public static Dto.DtoClasses.ActorPersonDto ProjectToActorPersonDto(this EntityModel.EntityClasses.PersonEntity entity)
		{
			return _compiledProjector(entity);
		}

		
		private static System.Linq.Expressions.Expression<Func<EntityModel.EntityClasses.PersonEntity, Dto.DtoClasses.ActorPersonDto>> CreateProjectionFunc()
		{
			return p__0 => new Dto.DtoClasses.ActorPersonDto()
			{
				CollectionId = p__0.CollectionId,
				Firstname = p__0.Firstname,
				Id = p__0.Id,
				Lastname = p__0.Lastname,
			};
		}
		
		

		/// <summary>Creates a primary key predicate to be used in a Where() clause in a Linq query which is executed on the database to fetch the original entity instance
		/// the specified <see cref="dto"/> object was projected from.</summary>
		/// <param name="dto">The dto object for which the primary key predicate has to be created for.</param>
		/// <returns>ready to use expression</returns>
		public static System.Linq.Expressions.Expression<Func<EntityModel.EntityClasses.PersonEntity, bool>> CreatePkPredicate(Dto.DtoClasses.ActorPersonDto dto)
		{
			return p__0 => p__0.Id == dto.Id;
		}

		/// <summary>Creates a primary key predicate to be used in a Where() clause in a Linq query which is executed on the database to fetch the original entity instances
		/// the specified set of <see cref="dtos"/> objects was projected from.</summary>
		/// <param name="dtos">The dto objects for which the primary key predicate has to be created for.</param>
		/// <returns>ready to use expression</returns>
		public static System.Linq.Expressions.Expression<Func<EntityModel.EntityClasses.PersonEntity, bool>> CreatePkPredicate(IEnumerable<Dto.DtoClasses.ActorPersonDto> dtos)
		{
			var ids = dtos.Select(p__1=>p__1.Id).ToList();
			return p__0 => ids.Contains(p__0.Id);
		}

		/// <summary>Creates a primary key predicate to be used in a Where() clause in a Linq query on an IEnumerable in-memory set of entity instances
		/// to retrieve the original entity instance the specified <see cref="dto"/> object was projected from.</summary>
		/// <param name="dto">The dto object for which the primary key predicate has to be created for.</param>
		/// <returns>ready to use func</returns>
		public static Func<EntityModel.EntityClasses.PersonEntity, bool> CreateInMemoryPkPredicate(Dto.DtoClasses.ActorPersonDto dto)
		{
			return p__0 => p__0.Id == dto.Id;
		}
		
		/// <summary>Updates the specified EntityModel.EntityClasses.PersonEntity entity with the values stored in the dto object specified</summary>
		/// <param name="toUpdate">the entity instance to update.</param>
		/// <param name="dto">The dto object containing the source values.</param>
		/// <remarks>The PK field of toUpdate is set only if it's not marked as readonly.</remarks>
		public static void UpdateFromActorPersonDto(this EntityModel.EntityClasses.PersonEntity toUpdate, Dto.DtoClasses.ActorPersonDto dto)
		{
			if((toUpdate == null) || (dto==null))
			{
				return;
			}
			toUpdate.CollectionId = dto.CollectionId;
			toUpdate.Id = dto.Id;
			toUpdate.Firstname = dto.Firstname;
			toUpdate.Lastname = dto.Lastname;
		}
	}
}


 