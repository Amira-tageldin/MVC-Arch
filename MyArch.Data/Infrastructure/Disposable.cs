using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArch.Data.Infrastructure
{
   public  class Disposable:IDisposable
   {

       private bool isDisbosable;

       ~Disposable()
       {

            Dispose(false);

        }
       public void Dispose()
       {
          GC.SuppressFinalize(this);

            Dispose(true);
       }


       public void Dispose(bool disposing)
       {

           if (!isDisbosable && disposing)
           {
           DisposeCore();     



           }

           isDisbosable = true;


       }



        public  virtual  void DisposeCore()
        { }

    }
}
