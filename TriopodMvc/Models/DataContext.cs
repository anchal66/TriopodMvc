using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TriopodMvc.Models
{
    public class DataContext: DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Admin> Admins { get; set; }

    }
}