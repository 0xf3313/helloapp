namespace helloapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            greetWhite();
            greetBlack();
            greetEveryone();
        }

        static void greetWhite()
        {
            Console.WriteLine("hello white");
        }

        static void greetBlack()
        {
            Console.WriteLine("hello black");
        }

        static void greetEveryone()
        {
            Console.WriteLine("hello everyone");        
        }
    }
}
