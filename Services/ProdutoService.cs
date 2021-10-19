using Microsoft.AspNetCore.Identity;
using ApiPneuStoreG03.Data;
using ApiPneuStoreG03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Services
{
 
    public class ProdutoService : IProdutoService
 
    {
        Context _context;
 
        public ProdutoService(Context context)
 
        {
            _context = context;
        }
 
        public List<Product> All()
 
        {
            return _context.Product.ToList();
        }

 
        public Product Get(int? id)
 
        {
            return _context.Product.FirstOrDefault(p => p.ProductID == id);
        }


 
        public bool Create(Product u)
 
        {
            try
            {
                u.created = DateTime.Now;
                _context.Product.Add(u);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

 
        public bool Delete(int? id)
 
        {   if (!_context.Product.Any(c => c.ProductID == id))
                throw new Exception("Produto não existe");
            try
            {
                _context.Product.Remove(Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

 
        public bool Update(Product p)
 
        {
            try
            {
                p.updated = DateTime.Now;
                _context.Product.Update(p);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        
 
        public List<Product> ProductByUserRole(string getRole)
 
        {
            var query1 = from Product in _context.Set<Product>()
                         join user in _context.Set<IdentityUser>()
                           on Product.createdById equals user.Id
                         join userRoles in _context.Set<IdentityUserRole<string>>()
                           on user.Id equals userRoles.UserId
                         join role in _context.Set<IdentityRole>()
                           on userRoles.RoleId equals role.Id
                         where role.Name.ToUpper() == getRole
                         select new Product()
                         {
                             ProductID = Product.ProductID,
                             ProductName = Product.ProductName,
                             UnitPrice = Product.UnitPrice,
                             Description = Product.Description,
                             ImagePath = Product.ImagePath,
                             CategoryID = Product.CategoryID

                         };
            return query1.ToList();

        }
    }
}
