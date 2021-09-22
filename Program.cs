using System;

namespace PalleOpgaverOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            data.Add();

            //Examples of using the Show() overloads
            Console.WriteLine("\nShow entire Teacherlist with their courses: ");
            data.Show(data.teacherList, true);

            Console.WriteLine("\nShow entire Teacherlist without their courses: ");
            data.Show(data.teacherList); // or Show(data.teacherList, false);

            Console.WriteLine("\nShow only 1 teacher without courses:");
            data.Show(data.teacherList[0]);

            Console.WriteLine("\nShow all courses");
            data.Show(data.courseList);

            Console.WriteLine("\nShow only 1 course. Returntype of Find is single object");
            data.Show(data.courseList.Find(c => c.Name.Contains("Database")));

            Console.WriteLine("\nShow 0 to many courses. Returntype of FindAll is a List");
            data.Show(data.courseList.FindAll(c => c.Teacher.Name.Contains("Henrik")));
        }
    }
}
