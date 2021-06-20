using System;
using System.Collections;
using System.Collections.Generic;
using AirTicketOffice.DAL.Entities;

namespace Model.Implementations
{
	public delegate ICollection<TEntity> GetAllEntitiesEventHandler<TEntity>(object sender, ModifyEntityEventArgs<TEntity> e)
		where TEntity : class, IEntity;

	public delegate void DeleteEntityEventHandler<TEntity>(object sender, ModifyEntityEventArgs<TEntity> e)
		where TEntity : class, IEntity;

	public delegate void SaveAllEntitiesEventHandler<TEntity>(object sender, ModifyAllEntitiesEventArgs<TEntity> e)
		where TEntity : class, IEntity;

	public delegate void SaveEntityEventHandler<TEntity>(object sender, ModifyEntityEventArgs<TEntity> e)
		where TEntity : class, IEntity;

	public class ModifyEntityEventArgs<TEntity> : EventArgs
		where TEntity : class, IEntity
	{
		public ModifyEntityEventArgs(TEntity entity)
		{
			Entity = entity;
		}

		public TEntity Entity { get; protected set; }

		public static implicit operator ModifyEntityEventArgs<TEntity>(TEntity entity) => 
			new ModifyEntityEventArgs<TEntity>(entity);
	}

	//public class ModifyAllEntitiesEventArgs<TEntity, TEntityCollection> : EventArgs
	//	where TEntity : class, IEntity
	//	where TEntityCollection : ICollection<TEntity>
	//{
	//	public ModifyAllEntitiesEventArgs(TEntityCollection entities)
	//	{
	//		Entities = entities;
	//	}

	//	public TEntityCollection Entities { get; protected set; }

	//	public static implicit operator ModifyAllEntitiesEventArgs<TEntity, TEntityCollection>(TEntityCollection entities) =>
	//		new ModifyAllEntitiesEventArgs<TEntity, TEntityCollection>(entities);
	//}

	public class ModifyAllEntitiesEventArgs<TEntity> : EventArgs
		where TEntity : class, IEntity
	{
		public ModifyAllEntitiesEventArgs(ICollection<TEntity> entities)
		{
			Entities = entities;
		}

		public ICollection<TEntity> Entities { get; protected set; }

		public static implicit operator ModifyAllEntitiesEventArgs<TEntity>(List<TEntity> entities) =>
			new ModifyAllEntitiesEventArgs<TEntity>(entities);
	}
}
