using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolDemo
{
    class StudentManager
    {
        public void Add(Student student)
        {
            Console.WriteLine("Öğrenci kayıt olmuştur: " +" "+ student.Name + " " + student.Surname + " " + student.Class);
        }

        public void Delete(Student student)
        {
            Console.WriteLine("Öğrencinin kaydı silinmiştir: " + " " + student.Name + " " + student.Surname + " " + student.Class);
        }

        public void List(Student[] students)
        {
            foreach (var s in students)
            {
                Console.WriteLine("Öğrenciler listelendi: " + " " + s.Name + " " + s.Surname + " " + s.Class);
            }
        }
    }
}
