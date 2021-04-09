using MQ.Core;
using System;

namespace MQ
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Create message queue");
                Console.WriteLine("2. Delete message queue");
                Console.WriteLine("3. Get message queue");

                var command = int.Parse(Console.ReadLine());

                if (command == 1)
                {
                    Console.WriteLine("Enter QM name: ");
                    CreateMQ(Console.ReadLine());
                }
                else if(command == 2)
                {
                    Console.WriteLine("Enter QM name: ");
                    DeleteMQ(Console.ReadLine());
                }
                else if(command == 3)
                {
                    PrintMQ();
                }
            }
        }

        static void CreateMQ(string name)
        {
            if (MessageQueue.Exists($@".\\{name}"))
            {
                Console.WriteLine($"Queue with name: { name } already exist.");
            }
            else
            {
                Console.WriteLine($"Queue .\\{name} not Found");
            }
            MessageQueue.Create($@".\{name}");
            Console.WriteLine("Queue Created.");
        }
        static void DeleteMQ(string name)
        {
            var res = MessageQueue.Delete(name);
            if(res)
                Console.WriteLine($".\\{name} deleted.");
            else
                Console.WriteLine($".\\{name} not deleted.");
        }

        static void PrintMQ()
        {
            foreach (var queue in MessageQueue.GetMessages())
            {
                Console.WriteLine(queue);
            }
        }
    }
}
