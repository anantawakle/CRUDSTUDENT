using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDSTUDENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;
            StudentCRUD crud = new StudentCRUD();
            do
            {
                Console.WriteLine("____________________________________");
                Console.WriteLine("1.Student List");
                Console.WriteLine("2.Get Student By Rollno");
                Console.WriteLine("3.Add student");
                Console.WriteLine("4.Update student");
                Console.WriteLine("5.Delect Student ");
                Console.WriteLine("Select your option");
                int option=Convert.ToInt32(Console.ReadLine());
                switch (option) 
                {
                    case 1:
                        List<Student> list = crud.GetStudents();
                        Console.WriteLine("Rollno\t Name\t Branch\t Percentage");
                        foreach(Student student in list)
                        {
                            Console.WriteLine($" {student.Rollno} \t{student.Name} \t{student.Branch} \t{student.Percentage}");
                            
                        }
                        break;
                        case 2:
                        Console.WriteLine("Enter the student roll no");
                        int rollno= Convert.ToInt32(Console.ReadLine());
                        Student s=crud.GetStudentByRollno(rollno);
                        Console.WriteLine("Rollno\t Name\t Branch\t percenatage");
                        Console.WriteLine($"{s.Rollno} \t{s.Name} \t{s.Branch} \t{s.Percentage}");
                        break;
                        case 3:
                        Student s1 = new Student();
                        Console.WriteLine("Enter the roll no");
                        s1.Rollno=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name");
                        s1.Name=Console.ReadLine();
                        Console.WriteLine("Enter the branch");
                        s1.Branch=Console.ReadLine();
                        Console.WriteLine("Enter the Percentage");
                        s1.Percentage=Convert.ToInt32(Console.ReadLine());
                        crud.AddStudent(s1);
                        Console.WriteLine("Student save");
                        break;
                        case 4:
                       Student s2= new Student();
                        Console.WriteLine("Enter the student roll no");
                        s2.Rollno=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name");
                        s2.Name=Console.ReadLine();
                        Console.WriteLine("Enter the branch");
                        s2.Branch=Console.ReadLine();
                        Console.WriteLine("Enter the percentage");
                        s2.Percentage=Convert.ToInt32(Console.ReadLine());
                        crud.UpgradeStudent(s2);
                        Console.WriteLine("Student updated");
                        break;
                        case 5:
                        Console.WriteLine("Enter the student rollno");
                        int rollno2=Convert.ToInt32(Console.ReadLine());
                        crud.DeletStudent(rollno2);
                        Console.WriteLine($" {rollno2} student deleted");
                        break;
                }
                Console.WriteLine("Press 1 for continue");
                no=Convert.ToInt32(Console.ReadLine());
            }
            while (no == 1);
        }
    }
}
