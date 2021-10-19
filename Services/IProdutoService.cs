using ApiPneuStoreG03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Services
{
 
    public interface IProdutoService
 
    {
 
        List<Product> All();
 
 
        Product Get(int? id);
 

 
        bool Create(Product p);
 

 
        bool Update(Product p);
 

      

 
        bool Delete(int? id);
 
 
        public List<Product> ProductByUserRole(string role);
 

    }
}
