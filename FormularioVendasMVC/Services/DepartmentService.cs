using FormularioVendasMVC.Data;
using FormularioVendasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FormularioVendasMVC.Services
{
    public class DepartmentService
    {
        private readonly FormularioVendasMVCContext _context;

        public DepartmentService(FormularioVendasMVCContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

    }
}