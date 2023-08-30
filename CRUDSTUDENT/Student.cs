using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSTUDENT
{
    public  class Student
    {
        public int Rollno{ get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public double Percentage { get; set; }
    }
    public class StudentCRUD
    {
        private List<Student> studentlist;
        public StudentCRUD()
        {
            studentlist = new List<Student>()
            { new Student { Rollno=1, Name="Ananta Wakle",Branch="Eletrical Engg",Percentage=85 },
            new Student { Rollno=2,Name="Akshay Patil",Branch="Computer science",Percentage=89},
            new Student { Rollno=3,Name="Durhesh Nemade",Branch="Mechanical Engg",Percentage=78}
            };
        }
        // display list//
        public List<Student>GetStudents() 
        {
            return studentlist;
        }

        // get single id//
        public Student GetStudentByRollno(int rollno)
        {
            // search for roll no in the collection//
            Student student = new Student();
            foreach(Student s in studentlist)
            {
                if(s.Rollno==rollno)// match the roll no//
                {
                    student=s; 
                    break;
                }
            }
            return student;
        }


        // add new student//
        public void AddStudent(Student s)
        {
            studentlist.Add(s);
        }
        // modify the student list//
        public void UpgradeStudent(Student s)
        {
            foreach(Student item in  studentlist)
            {
                if(item.Rollno==s.Rollno)
                {
                    item.Rollno=s.Rollno;
                    item.Name=s.Name;
                    item.Branch=s.Branch;
                    item.Percentage=s.Percentage;
                    break;
                }
            }
        }
        // remove student//
        public void DeletStudent(int  rollno)
        {
            foreach (Student item in studentlist)
            {
                if(item.Rollno==rollno)
                {
                    studentlist.Remove(item);
                    break;
                }
            }
        }
    }
}
