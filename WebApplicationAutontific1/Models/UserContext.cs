﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplicationAutontific1.Models
{
    public class UserContext:DbContext
    {
        public UserContext() :
              base("DBConnection")
        { }
        public DbSet<User> Users { get; set; }
    }
}