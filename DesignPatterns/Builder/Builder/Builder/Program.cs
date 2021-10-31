using System;

namespace Builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProductDirector director = new ProductDirector();
            var builder = new NewCustomerProductBuilder();
            director.GenerateProduct(builder);
            var model = builder.GetModel();
            Console.WriteLine(model.UnitPrice);
        }
    }

    public class ProductDirector
    {
        public void GenerateProduct(ProductBuilder builder)
        {
            builder.GetProductData();
            builder.ApplyDiscount();
            
        }
    }

    public class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool IsDiscountApplied { get; set; }
    }

    public abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();

        public abstract ProductViewModel GetModel();
    }

    public class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel _viewModel = new ProductViewModel();
        
        public override void GetProductData()
        {
            _viewModel.Id = 1;
            _viewModel.ProductName = "Chai";
            _viewModel.CategoryName = "Beverages";
            _viewModel.UnitPrice = 20;
            
        }

        public override void ApplyDiscount()
        {
            _viewModel.DiscountedPrice = _viewModel.UnitPrice * (decimal)0.90;
            _viewModel.IsDiscountApplied = true;
        }

        public override ProductViewModel GetModel()
        {
            return _viewModel;
        }
    }
    
    public class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel _viewModel = new ProductViewModel();
        
        public override void GetProductData()
        {
            _viewModel.Id = 1;
            _viewModel.ProductName = "Chai";
            _viewModel.CategoryName = "Beverages";
            _viewModel.UnitPrice = 20;
            
        }


        public override void ApplyDiscount()
        {
            _viewModel.DiscountedPrice = _viewModel.UnitPrice;
            _viewModel.IsDiscountApplied = false;
        }

        public override ProductViewModel GetModel()
        {
            return _viewModel;
        }
    }
}