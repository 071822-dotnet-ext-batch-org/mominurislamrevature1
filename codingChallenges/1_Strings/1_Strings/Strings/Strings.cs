using System;

namespace StringManipulationChallenge
{
    public class Program
    {  static void Main(string[] args)
        {

           // String fName = "sumon";
           // String lName = "Alom";
            /*
            *
            * implement the required code here and within the methods below.
            *
            */
            //when you call a method, you call it with arguments. The args values are held in a variable.
            Console.WriteLine("Enter a LowerCase String");
            string userInput1 = Console.ReadLine();
            String stringToUpperResult = StringToUpper(userInput1);
            Console.WriteLine(stringToUpperResult);

            Console.WriteLine("Enter a UpperCase String");
            string userInput2 = Console.ReadLine();
            String stringLowerResult = StringToLower(userInput2);
            Console.WriteLine(stringLowerResult);

            Console.WriteLine("Enter a whitespace string");
            string userInput3 = Console.ReadLine();
            String stringTrimResult = StringTrim(userInput3);
            Console.WriteLine(stringTrimResult);

            Console.WriteLine("Enter a Substring string");
            string userInput4 = Console.ReadLine();
            String stringSubstringResult = StringSubstring(userInput4, 1, 2);
            Console.WriteLine(stringSubstringResult );

            /* String stringSearchCharResult = SearchChar(userInput1,2);
            Console.WriteLine(stringSearchCharResult);
            */
            Console.WriteLine("Enter your First Name");
            string fName = Console.ReadLine();
             Console.WriteLine("Enter your First Name");
            string lName = Console.ReadLine();
            String stringConcatNamesResult = ConcatNames(fName,lName);
            Console.WriteLine(stringConcatNamesResult);

             
           




        }

        /// <summary>
        /// This method has one string parameter and will: 
        /// 1) change the string to all upper case and 
        /// 2) return the new string.
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>
        public static string StringToUpper(string myString)// the method itself has 'parameters'
        {
            // throw new NotImplementedException("StringToUpper method not implemented.");
            return myString.ToUpper();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) change the string to all lower case,
        /// 2) return the new string into the 'lowerCaseString' variable
        /// </summary>
        /// <param name="usersString"></param>
        /// <returns></returns>       
        public static string StringToLower(string usersString)
        {
           // throw new NotImplementedException("StringToUpper method not implemented.");
            return usersString.ToLower();
        }

        /// <summary>
        /// This method has one string parameter and will:
        /// 1) trim the whitespace from before and after the string, and
        /// 2) return the new string.
        /// HINT: When getting input from the user (you are the user), try inputting "   a string with whitespace   " to see how the whitespace is trimmed.
        /// </summary>
        /// <param name="usersStringWithWhiteSpace"></param>
        /// <returns></returns>
        public static string StringTrim(string usersStringWithWhiteSpace)
        {
            //throw new NotImplementedException("StringTrim method not implemented.");
             return usersStringWithWhiteSpace.Trim();
        }

        /// <summary>
        /// This method has three parameters, one string and two integers. It will:
        /// 1) get the substring based on the first integer element and the length 
        /// of the substring desired.
        /// 2) return the substring.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="firstElement"></param>
        /// <param name="lastElement"></param>
        /// <returns></returns>
        public static string StringSubstring(string x, int firstElement, int lengthOfSubsring)
        {
            //throw new NotImplementedException("StringSubstring method not implemented.");
            String result = x.Substring(firstElement,lengthOfSubsring);
            return result;

        }

        /// <summary>
        /// This method has two parameters, one string and one char. It will:
        /// 1) search the string parameter for first occurrance of the char parameter and
        /// 2) return the index of the char.
        /// HINT: Think about how StringTrim() (above) would be useful in this situation
        /// when getting the char from the user. 
        /// </summary>
        /// <param name="userInputString"></param>
        /// <param name="charUserWants"></param>
        /// <returns></returns>
        public static int SearchChar(string userInputString, char charUserWants)
        {
            //throw new NotImplementedException("SearchChar method not implemented.");
            int result = userInputString.IndexOf(charUserWants);
            return result;
        }

        /// <summary>
        /// This method has two string parameters. It will:
        /// 1) concatenate the two strings with a space between them.
        /// 2) return the new string.
        /// HINT: You will need to get the users first and last name in the 
        /// main method and send them as arguments.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <returns></returns>
        public static string ConcatNames(string fName, string lName)
        {
            //throw new NotImplementedException("ConcatNames method not implemented.");
            string resultConcat = fName + " " +lName;
            return resultConcat;
        }
    }//end of program
}