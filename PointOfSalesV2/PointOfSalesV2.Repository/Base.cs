using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using PointOfSalesV2.Entities;
using static PointOfSalesV2.Common.Enums;

namespace PointOfSalesV2.Repository
{
    public abstract class Base<T, U> : IBase<T>
          where T : class, ICommonData, new()
          where U : DbContext
    {
        protected readonly U _Context;
        private readonly DbSet<T> _DbSet;
        public  List<Language> languages;

        public Base(U context)
        {
            _Context = context;
            _DbSet = _Context.Set<T>();
          
        }

        public virtual Result<T> Add(T entity)
        {
            try
            {
                var translation = entity as IEntityTranslate;
                if (translation != null) 
                {
                    languages = _Context.Set<Language>().AsNoTracking().Where(x => x.Active == true).ToList();
                    entity.TranslationData=  TranslateUtility.SaveTranslation(entity, translation.TranslationData,languages);
                   
                }
                _Context.Set<T>().Add(entity);

                _Context.SaveChanges();

                return new Result<T>(entity.Id, 0, "OK", new List<T>() { entity }); ;
            }

            catch (Exception ex)
            {
                return new Result<T>(-1, -1, ex.Message, null, ex);
            }
          
        }

        public virtual void AddRange(IEnumerable<T> entities)
        {
            _Context.Set<T>().AddRange(entities);

            _Context.SaveChanges();
        }
        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _Context.Set<T>().RemoveRange(entities);

            _Context.SaveChanges();
        }



        public virtual Result<T> Remove(T entity)
        {
            try
            {
                _DbSet.Attach(entity);
                _Context.Entry<T>(entity).State = EntityState.Deleted;

                _Context.SaveChanges();
                return new Result<T>(0, 0, "OK");
            }

            catch (Exception ex) 
            {
                return new Result<T>(-1, -1, ex.Message, null, ex);
            }
          


        }

        public virtual Result<T> Remove(long id)
        {
            try
            {
                var entity = _DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id && x.Active == true);

                _Context.Entry<T>(entity).State = EntityState.Deleted;
                _Context.SaveChanges();
                return new Result<T>(0, 0, "OK");
            }

            catch (Exception ex)
            {
                return new Result<T>(-1, -1, ex.Message, null, ex);
            }

            
        }

        public virtual Result<T> Update(T entity, bool getFromDb=true)
        {
            try
            {
                var dbEntity =getFromDb? _DbSet.AsNoTracking().FirstOrDefault(x=>x.Id==entity.Id && x.Active==true):entity;
                var translation = dbEntity as IEntityTranslate;
                if (translation != null)
                {
                    languages = _Context.Set<Language>().AsNoTracking().Where(x => x.Active == true).ToList();
                    entity.TranslationData = TranslateUtility.SaveTranslation(entity, translation.TranslationData,languages);
                   
                }
                if (!getFromDb)
                {
                    _DbSet.Update(entity);
                }
                else 
                {
                    _DbSet.Attach(entity);
                    _Context.Entry<T>(entity).State = EntityState.Modified;
                }
                

                _Context.SaveChanges();

                return new Result<T>(entity.Id, 0, "OK", new List<T>() { entity });
            }

            catch (Exception ex)
            {
                return new Result<T>(-1, -1, ex.Message, null, ex);
            }
            
        }

        public virtual Result<T> GetAll(string sortExpression = null)
        {
            return new Result<T>(0,0,"OK", _DbSet.AsNoTracking().OrderBy(sortExpression).ToList());
        }

        public virtual IPagedList<T> GetPaged(int startRowIndex, int pageSize, string sortExpression = null)
        {
            return new PagedList<T>(_DbSet.AsNoTracking().Where(x=>x.Active==true), startRowIndex, pageSize);
        }


       

        public virtual Result<T> GetAll(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        {

            var query = filter == null ? _DbSet.AsNoTracking().OrderBy(sortExpression) : _DbSet.AsNoTracking().Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return new Result<T>(0,0,"OK", sortedResults.ToArray().ToList());
        }

        public virtual IQueryable<TResult> GetAll<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking().OrderBy(sortExpression) : _DbSet.AsNoTracking().Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return sortedResults.AsQueryable();
        }

        public int GetCount<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking() : _DbSet.AsNoTracking().Where(filter);

            return transform(query).Count();
        }

        public virtual IPagedList<T> GetPaged(Func<IQueryable<T>, IQueryable<T>> transform, Expression<Func<T, bool>> filter = null, int startRowIndex = -1, int pageSize = -1, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking().OrderBy(sortExpression) : _DbSet.AsNoTracking().Where(filter).OrderBy(sortExpression);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return new PagedList<T>(sortedResults, startRowIndex, pageSize);
        }

        public virtual IPagedList<TResult> GetPaged<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, int startRowIndex = -1, int pageSize = -1, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking() : _DbSet.AsNoTracking().Where(filter);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return new PagedList<TResult>(sortedResults, startRowIndex, pageSize);
        }

        public virtual Result<T> Get(long id)
        {
            try
            {
                var entity = _DbSet.AsNoTracking().FirstOrDefault(x => x.Id == id && x.Active == true);
                //TranslateUtility.Translate(entity, entity.TranslationData);
                return new Result<T>(0,0,"OK",new List<T>() { entity });
            }

            catch (Exception ex)
            {
                return new Result<T>(-1, -1, ex.Message, null, ex);
            }
          
        }

        public virtual Result<T> Get(Guid id)
        {
            try
            {
                var entity = _DbSet.Find(id);
                _Context.Entry<T>(entity).State = EntityState.Detached;
                return new Result<T>(0, 0, "OK", new List<T>() { entity });
            }

            catch (Exception ex)
            {
                return new Result<T>(-1, -1, ex.Message, null, ex);
            }
          
        }

        public virtual TResult Get<TResult>(Func<IQueryable<T>, IQueryable<TResult>> transform, Expression<Func<T, bool>> filter = null, string sortExpression = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking() : _DbSet.AsNoTracking().Where(filter);

            var notSortedResults = transform(query);

            var sortedResults = sortExpression == null ? notSortedResults : notSortedResults.OrderBy(sortExpression);

            return sortedResults.FirstOrDefault();
        }
        public virtual bool Exists(long id)
        {
            return _DbSet.AsNoTracking().Any(x=>x.Id==id && x.Active==true);
        }

        public virtual bool Exists(Func<IQueryable<T>, IQueryable<T>> selector, Expression<Func<T, bool>> filter = null)
        {
            var query = filter == null ? _DbSet.AsNoTracking() : _DbSet.AsNoTracking().Where(filter);

            var result = selector(query);

            return result.Any();
        }
    }
}
