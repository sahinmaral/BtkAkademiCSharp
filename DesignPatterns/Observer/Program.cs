namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();
            productManager.Attach(new CustomerObserver());
            productManager.Attach(new EmployeeObserver());

            productManager.UpdatePrice();


            Console.ReadLine();
        }
    }

    class ProductManager
    {
        List<Observer> Observers = new List<Observer>();
        public void UpdatePrice()
        {
            Console.WriteLine("Product price updated");
            Notify();
        }

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            Observers.Remove(observer);
        }

        private void Notify()
        {
            Observers.ForEach((observer) =>
            {
                observer.Update();
            });
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public class CustomerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to customer : Product price updated");
        }
    }

    public class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Message to employee : Product price updated");
        }
    }
}