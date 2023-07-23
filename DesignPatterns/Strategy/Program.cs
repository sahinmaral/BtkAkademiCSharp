namespace Strategy;

internal class Program
{

    /// <summary>
    /// Strategy dizayni ile birden fazla if-else bloklarindan kurtularak 
    /// belirlenen senaryolara gore siniflar olusturulup ana sinif icerisinde 
    /// property atanip ilgili durumda kullanilmak uzere gerekli sinifi instance
    /// olusturarak bu sayede daha temiz kod yazimini saglar.
    /// </summary>
    public static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.CreditCalculatorBase = new Before2020CreditCalculator();
        customerManager.SaveCredit();

        Console.ReadLine();
    }

    abstract class CreditCalculatorBase
    {
        public abstract void Calculate();
    }

    class Before2020CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using before2020");
        }
    }

    class After2020CreditCalculator : CreditCalculatorBase
    {
        public override void Calculate()
        {
            Console.WriteLine("Credit calculated using after2020");
        }
    }

    class CustomerManager
    {
        public CreditCalculatorBase CreditCalculatorBase { get; set; }
        public void SaveCredit()
        {
            Console.WriteLine("Customer manager business");
            CreditCalculatorBase.Calculate();
        }
    }
}