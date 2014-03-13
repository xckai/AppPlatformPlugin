using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppPlatform.Model.Models;

namespace AppPlatform.Model
{
    public class Class1
    {

        static void Main(string[] args)
        {
            using (var db = new Enterprise_AppContext())
            {

                //db.Database.Delete();
                db.SaveChanges();
            }


        }
    }
}