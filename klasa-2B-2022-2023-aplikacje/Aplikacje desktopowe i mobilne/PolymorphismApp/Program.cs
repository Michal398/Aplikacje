using System;

namespace PolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
            dog firstdog = new dog();
            dog seconddog = new dog("Burek", 5);

            dog thirddog = seconddog;
        }
    }
}
