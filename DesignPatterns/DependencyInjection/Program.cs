using Ninject;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IOC Container
            IKernel kernel = new StandardKernel();
            kernel.Bind<IProductDAL>().To<ProductDALWithEF>();

            ProductManager productManager = new ProductManager(kernel.Get<IProductDAL>());
            productManager.Save();

            Console.ReadLine();
        }
    }

    interface IProductDAL
    {
        public void Save();
    }

    class ProductDALWithEF : IProductDAL
    {
        public void Save()
        {
            Console.WriteLine("Saved with EF");
        }
    }

    class ProductDALWithNHirbate : IProductDAL
    {
        public void Save()
        {
            Console.WriteLine("Saved with NHirbate");
        }
    }

    class ProductManager
    {
        IProductDAL _productDAL;

        public ProductManager(IProductDAL productDAL)
        {
            _productDAL = productDAL;
        }

        public void Save()
        {
            Console.WriteLine("Business codes");
            _productDAL.Save();
        }
    }
}