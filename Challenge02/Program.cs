namespace Challenge02
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Parantheses("()"));
            //Console.WriteLine(Parantheses(")(()))"));
            //Console.WriteLine(Parantheses("("));
            Console.WriteLine(Parantheses.Check("(())((()())())"));
        }
    }
}