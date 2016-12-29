using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyArch.Data.Infrastructure
{
  public  interface IRepository <T> where T : class
  {
      void Add(T entity);
      void Remove(T entity);

      void Remove(Expression<Func<T, bool>> where);
      void Update(T entity);
      IEnumerable<T> GetAll();
      T Get(Expression<Func<T, bool>> where);
      T GetById(int id);
      IEnumerable<T> GetMany(Expression<Func<T, bool>> where);





  }
}
