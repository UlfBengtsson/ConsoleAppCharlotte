using System;

namespace ConsoleAppCharlotte
{
    class Program
    {
        int id = 0;
        //private int id = 0;

        /// <summary>
        /// some text
        /// </summary>
        /// <exception cref="Exception">If negative number</exception>
        public int MyId
        { 
            get
            {
                return id;
            }
            set
            {
                if (value < 0) 
                {
                    throw new Exception("MyId may not be negative!");
                }

                id = value;
            }
        }

        //defualt access level is Private
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


    }
}
/*
  C#        -   Java
  Public    -   Public
  Internal  -   Pakage
  Protected -   Protected
  Private   -   Private
 */
