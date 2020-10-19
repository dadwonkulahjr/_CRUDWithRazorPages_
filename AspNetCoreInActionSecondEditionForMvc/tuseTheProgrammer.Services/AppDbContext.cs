using AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreInActionSecondEditionForMvc.tuseTheProgrammer.Services
{
    public class AppDbContext : DbContext
    {
        public DbSet<tblPerson> TblPersons { get; set; }
        public DbSet<tblCity> TblCities { get; set; }

        public DbSet<tblDepartment> TblDepartments { get; set; }

        public DbSet<tblGender> TblGenders { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {

        }
    }
}
