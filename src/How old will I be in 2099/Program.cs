using System;

namespace How_old_will_I_be_in_2099
{
    // https://www.codewars.com/kata/5761a717780f8950ce001473
    // Philip's just turned four and he wants to know how old he will be in various years in the future such as 2090 or 3044.

    // His parents can't keep up calculating this so they've begged you to
    // help them out by writing a programme that can answer Philip's endless questions.

    // Your task is to write a function that takes two parameters: the year of birth 
    // and the year to count years in relation to. As Philip is getting more curious every day he may
    // soon want to know how many years it was until he would be born, so your function needs to work
    // with both dates in the future and in the past.

    // Provide output in this format:
    // For dates in the future: "You are ... year(s) old."
    // For dates in the past: "You will be born in ... year(s)."
    // If the year of birth equals the year requested return: "You were born this very year!"

    // "..." are to be replaced by the number, followed and proceeded by a single space.
    // Mind that you need to account for both "year" and "years", depending on the result.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateAge(2011, 2012));
        }

        // solution
        public static string CalculateAge(int birth, int yearTo)
        {
            // this is my codewars solution but this doesn't works on vs2017
            // return birth == yearTo ? "You were born this very year!" :
            //    birth > yearTo ? $"You will be born in {-(yearTo - birth)} {yearTo - birth == -1 ? "year": "years"}." :
            //    $"You are {yearTo - birth} {yearTo - birth == 1 ? "year": "years"} old.";

            // alternative solution
            if (birth == yearTo)
                return "You were born this very year!";

            if(birth > yearTo)
            {
                var result = $"You will be born in {-(yearTo - birth)} ";

                if(yearTo - birth == - 1)
                {
                    result += "year";
                }
                else
                {
                    result += "years";
                }

                return result;

            }
            else
            {
                var result = $"You are {yearTo - birth} ";

                if(yearTo - birth == 1)
                {
                    result += "year";
                }
                else
                {
                    result += "years";
                }

                return result += " old.";
            }
        }
    }
}
