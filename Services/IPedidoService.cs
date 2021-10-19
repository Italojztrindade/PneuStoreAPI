using ApiPneuStoreG03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Services
{
    public interface IPedidoService
 
    {
        bool Create(Pedido p);
 
        bool Delete(int? id);
 
        Pedido Get(int? id);
 
        List<Pedido> All();
 
        bool Update(Pedido p);
 
    }
}
