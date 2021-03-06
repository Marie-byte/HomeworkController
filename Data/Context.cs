﻿using Homework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Values> Values { get; set; }
        public DbSet<Student> Student {get; set;}
        public DbSet<Studentdescription> Studentdescription {get; set;}
    }
}
