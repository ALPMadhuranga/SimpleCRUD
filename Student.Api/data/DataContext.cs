using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Student.Api.data
{
    public class DataContext:DbContext // this class responsible for connecting to the database
    {
        public DataContext(DbContextOptions options):base(options){

        }

        public DbSet<Student> Students { get; set; }
    }
}