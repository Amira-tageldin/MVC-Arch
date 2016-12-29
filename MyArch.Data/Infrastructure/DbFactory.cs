using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArch.Data.Infrastructure
{
   public class DbFactory :Disposable,IDbfactory
   {
        MyDbContext _context;


       public MyDbContext Init()
       {
           return _context ?? (_context = new MyDbContext());
       }



       protected    virtual void DisposeCore()
       {
            if (_context!=null)
                _context.Dispose();
           



       }

    }
}
