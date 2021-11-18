using Microsoft.EntityFrameworkCore;
using MyGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame.Data
{
    public class MyGameContext : DbContext
    {
        public MyGameContext(DbContextOptions<MyGameContext> options)
            : base(options) { }
        public virtual DbSet<PersonModel> Person { get; set; }
    

        protected MyGameContext()
        {
        }
    }
}
