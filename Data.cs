using System;
using System.Collections.Generic;

namespace PalleOpgaverOOP
{
    internal class Data
    {
        //Example of Abstraction (Lists) & Encapsulation (the whole Data class)
        public List<Teacher> teacherList = new List<Teacher>();
        public List<Course> courseList = new List<Course>();

        //Creating the overloads while using the ToString overrides in WriteLine
        internal void Show(List<Teacher> teachers, bool showCourses = false)
        { foreach (var teacher in teachers) Show(teacher, showCourses); }
        internal void Show(Teacher teacher, bool showCourses = false)
        {
            Console.WriteLine(teacher);
            if (showCourses) Show(teacher.Courses);
        }
        internal void Show(List<Course> courses) { foreach (var course in courses) Show(course); }
        internal void Show(Course course) { Console.WriteLine(course); }

        //Adding the data for teachers and courses
        internal void Add()
        {
            //While the courseList is empty at the instantiation of the Teacher, it will be filled later
            //and used in the Teacher property: Courses, so it returns the courses with the right teacher.
            Teacher hpo = new Teacher(courseList) { Id = 117, Name = "Henrik Poulsen", Email = "hpo@tec.dk" };
            Teacher pwe = new Teacher(courseList) { Id = 112, Name = "Palle Westermann", Email = "pwe@tec.dk" };
            //An example of adding multiple objects at the same time
            teacherList.AddRange(new Teacher[] { pwe, hpo });

            //Adding Courses by adding directly to the courseList.
            courseList.Add(new Course()
            { Id = 16880, Name = "Object Oriented Programming", Classroom = "E310", Teacher = pwe });
            courseList.Add(new Course()
            { Id = 16475, Name = "GUI Programming", Classroom = "E310", Teacher = pwe });
            courseList.Add(new Course()
            { Id = 16474, Name = "Database Programming", Classroom = "E311", Teacher = hpo });
            courseList.Add(new Course()
            { Id = 16476, Name = "Clientside Programming", Classroom = "E311", Teacher = hpo });
        }
    }
}