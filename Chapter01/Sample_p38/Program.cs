using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_p38 {
    internal class Program {
        static void Main(string[] args) {
            Employee employee = new Employee() {
                Id = 100,
                Name = "山田太郎",
                Birthday = new DateTime(1992, 4, 5),
                DivisionName = "第一営業所",
            };
            Console.WriteLine("{0}{1}は、{2}に所属しています。",employee.Name,employee.Getage(),employee.DivisionName);

            Student student = new Student() {
                Birthday = new DateTime(2004, 1, 20),
                Name = "穂積亮",
                Grade = 2,
                ClassNumber = 1,
            };
            Console.WriteLine("{0}年{1}組の{2}は、{3:yyyy/M/d}生まれです。",student.Grade,student.ClassNumber,student.Name,student.Birthday);

            Person person = student;
            if (person is Student)
                Console.WriteLine("person is Student");

            object obj = student;
            if (obj is Student)
                Console.WriteLine("obj is Studnt");

        }
    }
}
