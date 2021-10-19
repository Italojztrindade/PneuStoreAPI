using ApiPneuStoreG03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Services
{
    public interface ICartItemService
 
    {
        List<CartItem> All();
 
        CartItem Get(int? id);
 
        bool Create(CartItem c);
 
        
        bool Update(CartItem c);
 
        bool Delete(int? id);
 

        List<CartItem> ProductConsulta(int? id);
 
        
    }
}
