using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWDay4
{
    /*Create an Employee class with Empid int, Empname string, Salaryperhour  float. 
     * Pass values to the members through Constructor.

Create a derived class called ParttimeEmployee with hoursofworking as a data member. 
    Instantiate the base class through the derived class constructor 

Create a Method called Calculate Salary() based on hoursofworking 
*/
    class Employee
    {
       protected int Empid;
       protected string Empname;
       protected float Salaryperhour;
       
        internal Employee(int eid,string en,float Sph)
        {
            this.Empid = eid;
            this.Empname = en;
            this.Salaryperhour = Sph;
        }
    }

    class ParttimeEmployee:Employee
    {
        float hoursofworking;
        internal ParttimeEmployee(int eid, string en, float Sph, float hoursofworking):base(eid,en,Sph)
        {
            this.hoursofworking = hoursofworking;
        }
        internal void EmpDetails()
        {
            float TotalSal=CalculateSalary(Salaryperhour, hoursofworking);
            Console.WriteLine("EmpolyeeId:{0}||Employee Name:{1}||TotalSalary:{2}", Empid, Empname, TotalSal);

        }
        float CalculateSalary(float Salaryperhour, float hoursofworking)
        {
            return Salaryperhour * hoursofworking;
        }

        static void Main ()
        {
            ParttimeEmployee PTE = new ParttimeEmployee(1001, "Rajesh", 200.50f, 2);
            PTE.EmpDetails();
            Console.Read();

        }

    }
}
