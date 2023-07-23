namespace Bridge;

internal class Program
{
    public static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.MessageSenderBase = new SmsSender();
        customerManager.UpdateCustomer();

        Console.ReadLine();
    }

    abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Message saved");
        }

        public abstract void Send(MessageBody body);
    }

    class SmsSender : MessageSenderBase
    {
        public override void Send(MessageBody body)
        {
            Console.WriteLine("{0} was sent via SmsSender",body.Title);
        }
    }

    class EmailSender : MessageSenderBase
    {
        public override void Send(MessageBody body)
        {
            Console.WriteLine("{0} was sent via EmailSender",body.Title);
        }
    }


    public class MessageBody
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }

    class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new MessageBody() { Title = "About the course"});
            Console.WriteLine("Customer updated");
        }
    }
}

