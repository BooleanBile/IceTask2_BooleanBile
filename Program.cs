using System.Collections;

namespace IceTask2_BooleanBile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arraylist of five student objects
            // not allowed List<T>
            ArrayList students = new ArrayList();

            students.Add(new Student( "NoThando", 98, 87));
            students.Add(new Student("Alex", 68, 47));
            students.Add(new Student("Joyce", 74, 96));
            students.Add(new Student("Oarabile", 37, 77));
            students.Add(new Student("Mfundo", 63, 55));

            //display details of students
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students.ToString());
                
            }
        }
    }
}
