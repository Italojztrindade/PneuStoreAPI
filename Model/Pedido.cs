using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Model
{
 
    public class Pedido
 
    {
 
        public int PedidoId { get; set; }
 
 
        public int UsuarioId { get; set; }
 
 
        public List<Product> Produtos { get; set; }
 
    }
}
