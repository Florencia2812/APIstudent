using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace APIstudent.Models
{
    public class DataContext : DbContext//prop tab tab
    {
        public DataContext() : base("DefaultConnection")  //ctor tab tab
        {

        }

        public System.Data.Entity.DbSet<APIstudent.Models.Student> Students { get; set; }
    }
}