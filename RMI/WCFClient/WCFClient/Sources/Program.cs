using System;
using System.ServiceModel;

namespace WCFClient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RemoteClient client = new RemoteClient();

                while (true)
                {
                    Console.WriteLine("1. Ping");
                    Console.WriteLine("2. Echo");
                    Console.WriteLine("3. Login");
                    Console.WriteLine("Enter command:");
                    var choose = int.Parse(Console.ReadLine());
                    switch (choose)
                    {
                        case 1: Console.WriteLine(client.Ping()); break;
                        case 2:
                            Console.WriteLine("Enter text: ");
                            var text = Console.ReadLine();
                            Console.WriteLine(client.Echo(text)); 
                            break;
                        case 3:
                            Console.WriteLine("Enter name: ");
                            var name = Console.ReadLine();
                            Console.WriteLine("Enter pass: ");
                            var pass = Console.ReadLine();
                            Console.WriteLine(client.Login(name, pass)); 
                            break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Press <ENTER> to terminate client.");
                Console.ReadLine();
            }
            catch (EndpointNotFoundException ex)
            {
                Console.WriteLine("Service endpoint not found: {0}", ex.Message);
                Console.ReadLine();
            }
            
        }
    }
}
