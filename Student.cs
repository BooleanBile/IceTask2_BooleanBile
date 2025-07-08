using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceTask2_BooleanBile
{
    // Create a class called Student.
    internal class Student
    {
        //private fields
        private string name;
        private double test1;
        private double test2;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Test1
        {
            get { return test1; }
            set { test1 = value; }
        }

        public double Test2
        {
            get { return test2; }
            set { test2 = value; }
        }

        //constructor to initialize the name and test marks
        public Student(string name, double test1, double test2)
        {
            this.name = name;
            this.test1 = test1;
            this.test2 = test2;

            try
            {

                // values are between 0 and 100
                bool notBetween = false;

                if (test1 < 0 && test1 > 100)
                {
                    notBetween = true;
                }
                else
                {
                    notBetween = false;
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                string message = "Test scores must be between 0 and 100.";


                throw new ArgumentOutOfRangeException(message);
            }

        }

        // a method ComputeAverage()

        public double ComputeAverage()
        {

            try
            {
                
                double average = (test1 + test2) / 2;

                return average;
            }
            catch (Exception)
            {
                string message = "fix you numbers, ensure Test scores must be between 0 and 100.";
                throw new Exception(message);

            }
            
        }

        //override ToString()

        public override string ToString()
        {
            return "Student's Name: " + Name+ "\nTest Mark 1: "+ Test1 + "%"+ "\nTest Mark 2: " + Test2 + "%"+ "\nAverage: " + ComputeAverage() + "%";
        }

    }
}
