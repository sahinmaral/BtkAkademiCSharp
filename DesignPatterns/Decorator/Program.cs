using System;

namespace Decorator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var personalCar = new PersonalCar()
            {
                Brand = "BMW",
                Model = "3.20",
                RentPrice = 2500
            };

            SpecialOffer specialOffer = new SpecialOffer(personalCar);
            specialOffer.DiscountPercentage = 10;

            Console.WriteLine("Concrete : {0}", personalCar.Brand);
            Console.WriteLine("Special offer", specialOffer.Brand);

            Console.WriteLine("---------------");

            Console.WriteLine("Concrete : {0}",personalCar.RentPrice);
            Console.WriteLine("Special offer : {0}",specialOffer.RentPrice);

            Console.ReadLine();
        }
    }

    abstract class CarBase
    {
        public abstract string Brand { get; set; }
        public abstract string Model { get; set; }
        public abstract decimal RentPrice { get; set; }
    }

    class PersonalCar : CarBase
    {
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override decimal RentPrice { get; set; }
    }

    class CommercialCar : CarBase
    {
        public override string Brand { get; set; }
        public override string Model { get; set; }
        public override decimal RentPrice { get; set; }
    }

    abstract class CarDecoratorBase : CarBase
    {
        private CarBase _carBase;

        protected CarDecoratorBase(CarBase carBase)
        {
            _carBase = carBase;
        }
    }

    class SpecialOffer : CarDecoratorBase
    {
        public int DiscountPercentage { get; set; }

        private readonly CarBase _carBase;

        public SpecialOffer(CarBase carBase) : base(carBase)
        {
            _carBase = carBase;
        }
        public override string Brand { get => _carBase.Brand; set { _carBase.Brand = value; } }
        public override string Model { get { return _carBase.Model; } set { _carBase.Model = value; } }
        public override decimal RentPrice { get { return _carBase.RentPrice - ((_carBase.RentPrice * DiscountPercentage) / 100); } set { } }
    }
}