using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(context.Products.Single(x=>x.Id == id));
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Product> SearchProductsByName(string text)
        {

            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(x => x.Name.ToLower().Contains(text)).ToList();
            }
            
        }
    }
}
