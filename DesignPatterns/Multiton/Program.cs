namespace Multiton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Camera nicon = Camera.GetCamera("nicon");
            Console.WriteLine("Nicon ID : {0}",nicon.Id);

            Camera niconInstanced = Camera.GetCamera("nicon");
            Console.WriteLine("NiconInstanced ID : {0}", niconInstanced.Id);
            

            Console.ReadLine();
        }
    }

    class Camera
    {
        static Dictionary<string, Camera> _cameras = new();
        static object _lock = new();
        public Guid Id { get; set; }
        public Camera()
        {
            Id = Guid.NewGuid();
        }

        public static Camera GetCamera(string brand)
        {
            lock (_lock)
            {
                if (!_cameras.ContainsKey(brand))
                {
                    _cameras.Add(brand, new Camera());
                }
            }

            return _cameras[brand];
        }
    }
}