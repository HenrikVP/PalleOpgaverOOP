using System.Collections.Generic;

namespace PalleOpgaverOOP
{
    internal class Teacher : BaseClass
    {
        List<Course> courseList;

        //Example of overload of default constructor
        public Teacher(List<Course> courses)
        {
            courseList = courses;
        }
        public string Email { get; set; }

        //Returning the courses of which the teacher was assigned during data creation.
        public List<Course> Courses { get { return courseList.FindAll(c => c.Teacher.Id == Id); }}
    }
}
