using MyArch.Data.Infrastructure;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyArch.Data.Infrastructure
{
 public    class RepositoryPattern <T> :IRepository<T>  where T:class
 {


     private readonly DbSet<T> dbSet;
     private  MyDbContext _context;

        protected  IDbfactory Dbfactory { get; private set; }



     protected  MyDbContext DbContext { get
     {
         return
             _context ?? (_context = Dbfactory.Init());
     } }

     protected RepositoryPattern(IDbfactory dbfactory)
     {
         Dbfactory = dbfactory;
         dbSet = DbContext.Set<T>();

     }

     public virtual void Add(T entity)
     {



         dbSet.Add(entity);

     }


     public virtual void Update(T entity)
     {
         dbSet.Attach(entity);
            DbContext.Entry(entity).State=EntityState.Modified;



     }

     public virtual void Remove(T entity)
     {



         dbSet.Remove(entity);
     }


     public virtual void Remove(Expression<Func<T, bool>> where)
     {
         IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();

         foreach (var obj in objects)
         {
             dbSet.Remove(obj);
         }

     }





     public virtual IEnumerable<T> GetAll()
     {

         return dbSet.ToList();
     }


     public virtual T GetById(int id)
     {
         return dbSet.Find(id);



     }



     public virtual T Get(Expression<Func<T, bool>> where)
     {

         return dbSet.Where(where).FirstOrDefault();

     }


        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }






    }
}
