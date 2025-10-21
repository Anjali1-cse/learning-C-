namespace SynchronizationInThreadsAndInterlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(FuncLock);
            t1.Start();
            Thread t2 = new Thread(FuncMonitor);
            t2.Start();
            Thread t3 = new Thread(FuncInterlocked);
            t3.Start();

        }

        static int i = 0;
        static object lockObject = new object();

        static void FuncLock()
        {
            lock (lockObject)
            {

                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;


            }

        }

        static void FuncMonitor()
        {
            Monitor.Enter(lockObject);
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            i++;

            Console.WriteLine("Second Monitor " + i.ToString());
            i++;

            i++;
            Console.WriteLine("Second Monitor " + i.ToString());
            // }
            Monitor.Exit(lockObject);
        }
        static void FuncInterlocked()
        {

            Interlocked.Add(ref i, 10);   //i+=10
            Console.WriteLine("Third Interlocked " + i.ToString());

            Interlocked.Increment(ref i); //++i;
            Console.WriteLine("Third Interlocked " + i.ToString());

            Interlocked.Decrement(ref i); //--i;
            Console.WriteLine("Third Interlocked " + i.ToString());

            Interlocked.Exchange(ref i, 100); //i = 100;
            Console.WriteLine("Third Interlocked " + i.ToString());
        }

    }
}