using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTBank
{

    class Class1
    {
        public string[] gClass = { "A+, You Performed Excellently Well", "A, You Performed Very Well", "B, You Performed Well ", "C, You Performed Averagely", "P, You Passed The Course ", "You Failed `score`: F", "Out Of Range." };

        public string yourGrade(int score)
        {
            if (score < 0 || score > 100)
            {
                return gClass[6];
            }
            else if (score > 89 && score < 101)
            {
                return gClass[0];
            }
            else if (score > 69 && score < 90)
            {
                return gClass[1];
            }
            else if (score > 59 && score < 70)
            {
                return gClass[2];
            }
            else if (score > 49 && score < 60)
            {
                return gClass[3];
            }
            else if (score > 39 && score < 49)
            {
                return gClass[4];
            }
            else
            {
                return gClass[5];
            }
            //Console.WriteLine(score);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Name: ");
            string username = Console.ReadLine();
            Console.WriteLine("Please Enter Your Course: ");
            string coursename = Console.ReadLine();
            Console.WriteLine("Please Enter Your Score: ");






            try
            {
                int grade_Score = Convert.ToInt32(Console.ReadLine());
                Class1 p = new Class1();
                //Outputing all that has been received from user and grading.
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Hi " + username);
                Console.WriteLine("Your Course Is " + coursename);
                Console.WriteLine("Your Grade Is: " + p.yourGrade(grade_Score));
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("***************************************************************************");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }


        }
    }
}
