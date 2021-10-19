using Microsoft.EntityFrameworkCore;
using ApiPneuStoreG03.Data;
using ApiPneuStoreG03.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPneuStoreG03.Services
{
    public class CartService : ICartItemService
 
    {

        Context _context;
 
        public CartService(Context context)
 
        {
            this._context = context;
        }
 
        public List<CartItem> All()
 
        {
            return _context.CartItem.ToList();
        }

      

 
        public bool Create(CartItem c)
 
        {
            try
            {
                _context.CartItem.Add(c);
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
                _context.CartItem.Remove(Get(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

 
        public CartItem Get(int? id)
 
        {
            return _context.CartItem.Find(id);
        }

 
        public bool Update(CartItem c)
 
        {
            try
            {
                _context.CartItem.Update(c);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

 
        public List<CartItem> ProductConsulta(int? id)
 
        {
            var query1 = $"SELECT * FROM Cart WHERE cartId = '{id}'";

            return _context.CartItem.FromSqlRaw(query1).ToList();
        }

    }
}
