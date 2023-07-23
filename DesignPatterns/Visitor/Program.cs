namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager() { Name = "Sahin", Salary = 6000 };
            Manager manager2 = new Manager() { Name = "Hasan", Salary = 5000 };

            Worker worker1 = new Worker() { Name = "Ali", Salary = 1000 };
            Worker worker2 = new Worker() { Name = "Mehmet", Salary = 2000 };

            manager1.SubOrdinates.Add(manager2);

            manager2.SubOrdinates.Add(worker1);
            manager2.SubOrdinates.Add(worker2);

            OrganizationStructure organizationStructure = new OrganizationStructure(manager1);

            PayrollVisitor payrollVisitor = new PayrollVisitor();
            PayriseVisitor payriseVisitor = new PayriseVisitor();

            organizationStructure.Accept(payrollVisitor);
            organizationStructure.Accept(payriseVisitor);




            Console.ReadLine();
        }
    }

    class OrganizationStructure
    {
        public EmployeeBase Employee;

        public OrganizationStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }

    abstract class EmployeeBase
    {
        public abstract void Accept(VisitorBase visitor);
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    class Manager : EmployeeBase
    {
        public List<EmployeeBase> SubOrdinates { get; set; } = new List<EmployeeBase>();
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);

            SubOrdinates.ForEach((employee) =>
            {
                employee.Accept(visitor);
            });
        }
    }

    class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }

    abstract class VisitorBase
    {
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);
    }

    class PayrollVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} paid {1}",worker.Name,worker.Salary);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} paid {1}", manager.Name, manager.Salary);
        }
    }

    class PayriseVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine("{0} salary increased to {1}", worker.Name, worker.Salary*(decimal)1.1);
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine("{0} salary increased to {1}", manager.Name, manager.Salary * (decimal)1.2);
        }
    }
}