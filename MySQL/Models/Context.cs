using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;


namespace MySQL.Models
{
    public class Context
    {
    }

    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class context : DbContext
    {
        public context()
            : base("MySqlConnection")
        {
            Database.SetInitializer<context>(new DropCreateDatabaseAlways<context>());
            //Database.SetInitializer<Context>(null);           
        }
        public DbSet<RegisterViewModel> users { get; set; }     
    }
}