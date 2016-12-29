using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArch.Data.Infrastructure
{
   public class UnitOfWork :IUnitOfWork
   {
       private  MyDbContext _context;

       private IDbfactory _dbfactory;

       public UnitOfWork( IDbfactory dbfactory)
       {
           _dbfactory = dbfactory;
       }


       public MyDbContext Context { get { return _context ?? (_context = _dbfactory.Init()); }
                
                
                
                  }

       public void Commit()
       {
            Context.Commit();
       }
    }
}
