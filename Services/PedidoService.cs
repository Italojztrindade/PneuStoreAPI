using ApiPneuStoreG03.Data;
using ApiPneuStoreG03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Services
{
 
    public class PedidoService : IPedidoService
 
    {
        Context _context;
 
        public PedidoService(Context context)
 
        {
            this._context = context;

        }
       

 
        public bool Create(Pedido p)
 
        {
            try
            {
                _context.Add(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

 
        public bool Delete(int? id)
 
        {
            try
            {
                _context.Remove(this.Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

 
        public Pedido Get(int? id)
 
        {
            return _context.Pedido.FirstOrDefault(p => p.PedidoId == id);
        }

 
        public List<Pedido> All()
 
        {
            return _context.Pedido.ToList();
        }

 
        public bool Update(Pedido p)
 
        {

            try
            {
                _context.Update(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
