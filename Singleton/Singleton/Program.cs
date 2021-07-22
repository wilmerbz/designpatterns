using Singleton.Implementation;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Singleton!");
            Console.WriteLine("Basic: 1, Multi-Thread: 2: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BasicDemo();
                    break;

                case "2":
                    MultiThreadDemo();
                    break;

                default:
                    break;
            }

            Console.ReadLine();

        }

        

        private static void BasicDemo()
        {
            BasicSingleton.Instance.DoSomething(1);
            BasicSingleton.Instance.DoSomething(2);
            BasicSingleton.Instance.DoSomething(3);
        }

        private static void MultiThreadDemo()
        {

            int numberOfThreads = 3;

            Console.WriteLine($"Using singleton from {numberOfThreads} threads in parallel.");


            for (int index = 0; index < numberOfThreads; index++)
            {
                var threadIndex = index;
                // Using Threads:
                var thread = new Thread(() => {

                    BasicSingleton.Instance.DoSomething(threadIndex);

                });

                thread.Start();

                // Using Tasks:
                //Task.Run(()=> {
                //    BasicSingleton.Instance.DoSomething(index);
                //});
            }


            Console.WriteLine($"Waiting some time...");

            Thread.Sleep(6000);

            Console.WriteLine($"Using it again after some time...");

            BasicSingleton.Instance.DoSomething(999);

        }

    }
}
