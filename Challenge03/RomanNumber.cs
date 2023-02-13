namespace Challenge03
{
    internal partial class Program
    {
        public class RomanNumber
        {
            public static string Convert(int number)
            {
                if (number > 3999) return "Numbers must be lower than 4000";

                var romanChars = new char[] { 'I', 'V', 'X', 'L', 'C', 'D', 'M' , ' ', ' '};

                var units = 1;
                var idx = 0;
                var resp = new List<string>() { };

                while(number > 0)
                {
                    var unitInt = units;
                    var unitRoman = romanChars[idx];

                    var mediumInt = units * 5;
                    var mediumRoman = romanChars[idx+1];

                    var nextUnitRoman =  romanChars[idx+2];

                    var digit = (number % 10) * unitInt;

                    number /= 10;
                    units *= 10;
                    idx += 2;

                    if (digit == 0)
                        continue;

                    if (digit >= unitInt && digit < (mediumInt - unitInt))
                    {
                        var r = new String(unitRoman, digit/unitInt);
                        resp.Insert(0, r);
                    }
                    else if (digit == mediumInt - unitInt)
                    {
                        resp.Insert(0, unitRoman.ToString() + mediumRoman.ToString() );
                    }
                    else if(digit >= mediumInt && digit < (unitInt * 10 - unitInt))
                    {
                        var rest = ((digit - mediumInt) / unitInt) ;
                        var r = new String(unitRoman, rest);
                        resp.Insert(0, mediumRoman.ToString() + r );

                    }else if (digit == (unitInt * 10) - unitInt)
                    {
                        resp.Insert(0, unitRoman.ToString() + nextUnitRoman.ToString() );
                    }
                }

                return  string.Join("", resp);
            }
        }

    }

}