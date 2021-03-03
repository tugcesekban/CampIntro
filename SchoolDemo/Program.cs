using System;

namespace SchoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Can";
            student.Surname = "Vekil";
            student.Class = 3;

            Student student2 = new Student();
            student2.Name = "Buket";
            student2.Surname = "Deniz";
            student2.Class = 4;

            Student student3 = new Student();
            student3.Name = "Mehmet";
            student3.Surname = "Akın";
            student3.Class = 2;

            Student[] students = new Student[] { student, student2, student3 };

            StudentManager studentManager = new StudentManager();
            studentManager.Add(student);
            studentManager.Delete(student2);
            studentManager.List(students);

        }
    }
}
