using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp1
{

    class Program
    {

        enum Monthes
        {
            Jan,
            Feb,
            March,
            Apr,
            Mai,
            Jone,
            Jully,
            Augh,
            Sept,
            October,
            November,
            Dec
        }

        static void Main(string[] args)
        {

            //Monthes s = Monthes.Feb;

            // start point to my program
            // sample programme
            //write the code in the main
            // or call to any code in the main
            // call function or methods

            //output
            //Console.WriteLine("Hello worled");
            //Ctrl+F5
            //input
            //Console.ReadLine();


            //how to declare variables
            //data type +variable name+;
            //assign value to variable

            /*
            Console.WriteLine("Please Enter Your Data");
            string fName = Console.ReadLine();
            Console.WriteLine("You Enterd name: "+fName);
            */


            #region variable
            /*
                System.Console.WriteLine("");
                Console.WriteLine("Enter First Number");
                // cast to int
                int fNumber =int.Parse(Console.ReadLine());//10

                Console.WriteLine("Enter Second Number");
                // cast to int
                int sNumber = int.Parse(Console.ReadLine());//20

                Console.WriteLine("The result of Sumtion is : "+(fNumber+sNumber));


                int result = fNumber + sNumber;
                Console.WriteLine("sum: "+result);

                result = fNumber - sNumber;
                Console.WriteLine("substract: "+result);
                result = fNumber * sNumber;
                Console.WriteLine("Multiply: "+result);
                result = fNumber / sNumber;
                Console.WriteLine("divid: " + result);
                Console.ReadLine();
            */
            #endregion


            /*
            // implicit
            int a = 120;
            long b=5;
            //b = a;
            //Console.WriteLine(b);

            //
            //Explicit  cast
            a = (int)b;
            Console.WriteLine(a);
            */
            /*
            try
            {
                Console.WriteLine("Enter Your Number");
                string str = Console.ReadLine();
                int intNumber = Convert.ToInt32(str);
                Console.WriteLine(intNumber);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          */


            /*

            Console.WriteLine("Enter First Name");
            string fName = Console.ReadLine();

            Console.WriteLine("Enter Second Name");
            string sName = Console.ReadLine();


            Console.WriteLine("Your full name is :"+fName+" "+sName);
            */


            #region Statments
            // if condition


            #region example 1
            /*
            Console.WriteLine("Enter User Name");
            string userName = Console.ReadLine();
           
            if (userName=="ahmed")
            {
                Console.WriteLine("Welcome {0} :\n",userName);

               k:
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine();
                if (password=="123")
                {
                    Console.WriteLine("You are welcome");
                }
                else
                {
                    Console.WriteLine("Invaild Password");
                    goto k;
                }
            }
            else
            {
                Console.WriteLine("Not Valid User");

            }
            */
            #endregion

            #region example 2
            /*
            s:
            Console.WriteLine("Enter Your Degree");
            int degree = int.Parse( Console.ReadLine());
            if (degree>=0&&degree<50)
            {
                Console.WriteLine("Faild");
            }
            else if(degree>=50&&degree<65)
            {
                Console.WriteLine("Pass");
            }
            else if (degree >= 65 && degree < 80)
            {
                Console.WriteLine("Good");
            }

            else if (degree >= 80 && degree < 90)
            {
                Console.WriteLine("Very Good");
            }
            else if (degree >= 90 && degree <= 100)
            {
                Console.WriteLine("Excllent");
            }
            else
            {
                Console.WriteLine("Out Of Rang");
            }
            goto s;
            */
            #endregion


            // switch


            #region example 3
            /*
            g:
            Console.WriteLine("Enter User Name");
            string userName = Console.ReadLine();
            userName = userName.ToLower();
            switch (userName)
            {
                case "ahmed":
                    Console.WriteLine("Wellcome Ahmed");
                    break;
                case "ali":
                    Console.WriteLine(" wellcome Ali");
                    break;
                case "najla":
                case "sawssan":
                    Console.WriteLine("Invaild in session most of time");
                    break;
                default:
                    Console.WriteLine("Invalid User");
                    break;
            }
            goto g;
            */
            #endregion

            #region Example 4   
        H:
            try
            {
        
                Console.WriteLine("Enter Month Name");
                string a = Console.ReadLine();
                // how to cast string to enum
                // multi cast
                Monthes m = (Monthes)Enum.Parse(typeof(Monthes), a);

                switch (m)
                {
                    case Monthes.Feb:
                        Console.WriteLine("28 day");
                        break;
                    case Monthes.Apr:
                    case Monthes.Jone:
                    case Monthes.Sept:
                    case Monthes.November:
                        Console.WriteLine("30 Days");
                        break;
                    default:
                        Console.WriteLine("31 Days");
                        break;
                }
                goto H;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                goto H;
            }
           

            #endregion








            #endregion


        }


    }

}
