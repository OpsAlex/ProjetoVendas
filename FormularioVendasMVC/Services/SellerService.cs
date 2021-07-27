using FormularioVendasMVC.Data;
using FormularioVendasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormularioVendasMVC.Services
{
    public class SellerService
    {
        private readonly FormularioVendasMVCContext _context;

        public SellerService(FormularioVendasMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            // esse comando irá atualizar no banco de dados
            _context.SaveChanges();
        }
        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            // esse comando irá atualizar no banco de dados a alteração feita na lista
            _context.SaveChanges();
        }
    }
}