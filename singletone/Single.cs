using System;

//کلاس سینگلتون
namespace singletone
{
    public class Single
    {
        private static Single instance;
        private static readonly object padlock = new object();

        private Single()
        {
            Console.WriteLine("get instatcw 1");
        }

        public static Single GetSingle
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new Single();
                    return instance;
                }
            }
        }
    }
}