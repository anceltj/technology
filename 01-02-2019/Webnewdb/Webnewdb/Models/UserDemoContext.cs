using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Webnewdb.Models
{
    public class UserDemoContext:DbContext
    {
         public  UserDemoContext()
             :base("mycon")
    {
        DropCreateDatabaseIfModelChanges<UserDemoContext> d= new DropCreateDatabaseIfModelChanges<UserDemoContext>();
        Database.SetInitializer(d);

    }
         public DbSet<Userdemo> usersdemo { get; set; }

         public System.Data.Entity.DbSet<Webnewdb.Models.Student> Students { get; set; }
    }
}