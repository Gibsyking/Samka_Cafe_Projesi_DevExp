using FluentValidation;
using SamkaCafe.Entitiy.Interfaces;
using SamkaCafe.Entitiy.Tools;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SamkaCafe.Entitiy.Repository
{
    public class EntityRepostoryBase<TContext, TEntity,TValidator> : EntityRepostory<TContext, TEntity>
        where TContext : DbContext, new()
        where TEntity : class,IEntity, new()
        where TValidator:IValidator,new()
    {
        public bool AddOrUpdate(TContext contex, TEntity entity)
        {
            TValidator validator = new TValidator();
            bool ValidationResult = ValidatorTools.Validates(validator,entity);
            if (ValidationResult)
            {
                contex.Set<TEntity>().AddOrUpdate(entity);
            }
            return ValidationResult;
           
        }

        public void Delete(TContext contex, Expression<Func<TEntity, bool>> filter)
        {
            contex.Set<TEntity>().Remove(contex.Set<TEntity>().FirstOrDefault(filter)); // SİLME
        }

        public List<TEntity> GetAll(TContext contex, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? contex.Set<TEntity>().ToList() : contex.Set<TEntity>().Where(filter).ToList(); // LİSTELEME
        }

        public TEntity GetbyFilter(TContext contex, Expression<Func<TEntity, bool>> filter)
        {
            return contex.Set<TEntity>().FirstOrDefault(filter); // FİLTREMEYE GİT
        }

        public void Save(TContext contex)
        {
            contex.SaveChanges(); // KAYDETME
        }
    }
}
