﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.3.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dto.Persistence
{
	/// <summary>Static class for (extension) methods for fetching and projecting instances of Dto.DtoClasses.CoreIncidentDto from / to the entity model.</summary>
	public static partial class CoreIncidentDtoPersistence
	{
		#region Statics
		private static readonly System.Linq.Expressions.Expression<Func<EntityModel.EntityClasses.IncidentEntity, Dto.DtoClasses.CoreIncidentDto>> _projectorExpression = CreateProjectionFunc();
		private static readonly Func<EntityModel.EntityClasses.IncidentEntity, Dto.DtoClasses.CoreIncidentDto> _compiledProjector = CreateProjectionFunc().Compile();
		#endregion	
	
		/// <summary>Empty static ctor for triggering initialization of static members in a thread-safe manner</summary>
		static CoreIncidentDtoPersistence()
		{
		}
	
		/// <summary>Extension method which produces a projection to Dto.DtoClasses.CoreIncidentDto which instances are projected from the 
		/// results of the specified baseQuery, which returns EntityModel.EntityClasses.IncidentEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <returns>IQueryable to retrieve Dto.DtoClasses.CoreIncidentDto instances</returns>
		public static IQueryable<Dto.DtoClasses.CoreIncidentDto> ProjectToCoreIncidentDto(this IQueryable<EntityModel.EntityClasses.IncidentEntity> baseQuery)
		{
			return baseQuery.Select(_projectorExpression);
		}
		
		
		/// <summary>Extension method which produces a projection to Dto.DtoClasses.CoreIncidentDto which instances are projected from the
		/// EntityModel.EntityClasses.IncidentEntity entity instance specified, the root entity of the derived element returned by this method.</summary>
		/// <param name="entity">The entity to project from.</param>
		/// <returns>EntityModel.EntityClasses.IncidentEntity instance created from the specified entity instance</returns>
		public static Dto.DtoClasses.CoreIncidentDto ProjectToCoreIncidentDto(this EntityModel.EntityClasses.IncidentEntity entity)
		{
			return _compiledProjector(entity);
		}

		
		private static System.Linq.Expressions.Expression<Func<EntityModel.EntityClasses.IncidentEntity, Dto.DtoClasses.CoreIncidentDto>> CreateProjectionFunc()
		{
			return p__0 => new Dto.DtoClasses.CoreIncidentDto()
			{
				CollectionId = p__0.CollectionId,
				Grouping = p__0.Grouping,
				Id = p__0.Id,
				ItemId = p__0.ItemId,
			};
		}
		
		

		/// <summary>Creates a primary key predicate to be used in a Where() clause in a Linq query which is executed on the database to fetch the original entity instance
		/// the specified <see cref="dto"/> object was projected from.</summary>
		/// <param name="dto">The dto object for which the primary key predicate has to be created for.</param>
		/// <returns>ready to use expression</returns>
		public static System.Linq.Expressions.Expression<Func<EntityModel.EntityClasses.IncidentEntity, bool>> CreatePkPredicate(Dto.DtoClasses.CoreIncidentDto dto)
		{
			return p__0 => p__0.Id == dto.Id;
		}

		/// <summary>Creates a primary key predicate to be used in a Where() clause in a Linq query which is executed on the database to fetch the original entity instances
		/// the specified set of <see cref="dtos"/> objects was projected from.</summary>
		/// <param name="dtos">The dto objects for which the primary key predicate has to be created for.</param>
		/// <returns>ready to use expression</returns>
		public static System.Linq.Expressions.Expression<Func<EntityModel.EntityClasses.IncidentEntity, bool>> CreatePkPredicate(IEnumerable<Dto.DtoClasses.CoreIncidentDto> dtos)
		{
			var ids = dtos.Select(p__1=>p__1.Id).ToList();
			return p__0 => ids.Contains(p__0.Id);
		}

		/// <summary>Creates a primary key predicate to be used in a Where() clause in a Linq query on an IEnumerable in-memory set of entity instances
		/// to retrieve the original entity instance the specified <see cref="dto"/> object was projected from.</summary>
		/// <param name="dto">The dto object for which the primary key predicate has to be created for.</param>
		/// <returns>ready to use func</returns>
		public static Func<EntityModel.EntityClasses.IncidentEntity, bool> CreateInMemoryPkPredicate(Dto.DtoClasses.CoreIncidentDto dto)
		{
			return p__0 => p__0.Id == dto.Id;
		}
		
		/// <summary>Updates the specified EntityModel.EntityClasses.IncidentEntity entity with the values stored in the dto object specified</summary>
		/// <param name="toUpdate">the entity instance to update.</param>
		/// <param name="dto">The dto object containing the source values.</param>
		/// <remarks>The PK field of toUpdate is set only if it's not marked as readonly.</remarks>
		public static void UpdateFromCoreIncidentDto(this EntityModel.EntityClasses.IncidentEntity toUpdate, Dto.DtoClasses.CoreIncidentDto dto)
		{
			if((toUpdate == null) || (dto==null))
			{
				return;
			}
			toUpdate.CollectionId = dto.CollectionId;
			toUpdate.Grouping = dto.Grouping;
			toUpdate.Id = dto.Id;
			toUpdate.ItemId = dto.ItemId;
		}
	}
}


 