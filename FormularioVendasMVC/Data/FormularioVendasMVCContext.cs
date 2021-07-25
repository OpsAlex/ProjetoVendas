using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FormularioVendasMVC.Models;

namespace FormularioVendasMVC.Data
{
    public class FormularioVendasMVCContext : DbContext
    {
        public FormularioVendasMVCContext (DbContextOptions<FormularioVendasMVCContext> options)
            : base(options)
        {
        }

        public DbSet<FormularioVendasMVC.Models.Department> Department { get; set; }
    }
}
