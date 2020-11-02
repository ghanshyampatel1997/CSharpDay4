using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HWDay4
{
    /*   Create an Abstract class Student with  Name, StudentId, Grade as members 
     *   and also an abstarct method Boolean Ispassed(grade) 
     *   which takes grade as an input and checks whether student passed the course or not.  

Create 2 Sub classes Undergraduate and Graduate 
    that inherits all members of the student and overrides Ispassed() method 

For the UnderGrad class, if the grade is above 70.0, 
    then isPassed returns true, otherwise it returns false. 
    For the Grad class, if the grade is above 80.0, 
    then isPassed returns true, otherwise returns false.
 */
    abstract class Student
    {

        protected int StudentId = 101;
        internal int Grade=75;
        protected string SName = "Parag";

        internal abstract Boolean Ispassed(int Grade);
        
        
    }
    class Undergraduate : Student
    {
        internal void Details()
        {
            Boolean Result=Ispassed(Grade);
            Console.WriteLine("Is Student {0} with having student id {1}, passed exam? ", SName, StudentId);
            Console.WriteLine(Result);
        }
        internal override Boolean Ispassed(int Grade)
        {
        
            if (Grade >= 70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Graduate : Student
    {
        internal void Details()
        {
            Boolean Result = Ispassed(Grade);
            Console.WriteLine("Is Student {0} with having student id {1}, passed exam? ", SName, StudentId);
            Console.WriteLine(Result);
        }
    
        internal override Boolean Ispassed(int Grade)
        {
            if (Grade >= 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Studentall
    {
        static void Main()
        {

            Undergraduate UG = new Undergraduate();
            UG.Details();
                     
            Graduate G = new Graduate();
            G.Details();
            Console.Read();

            
        }
    }

}
