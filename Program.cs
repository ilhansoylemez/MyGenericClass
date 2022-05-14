using System;

namespace MyGenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyGeneric<string> Product = new MyGeneric<string>();

            Product.Add("ilhan");
            Product.Add("furkan");
            Console.WriteLine(Product.Length);

            foreach (var item in Product.Items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
