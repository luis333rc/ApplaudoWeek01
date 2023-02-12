namespace Challenge02
{
    internal partial class Program
    {
        public class Parantheses
        {
            public static bool Check(string parenthesis)
            {
                var count = 0;

                foreach (var par in parenthesis)
                {
                    if (par == '(')
                        count++;
                    else if (par == ')')
                        count--;
                    else
                        return false;

                    if (count < 0) return false;
                }

                return count == 0;
            }
        }
        
    }
}