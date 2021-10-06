using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        public abstract class Student
        {
            public string name;
            public string state;

            public Student(string name_)
            {
                this.name = name_;
                this.state = "";
            }

            public void Read()
            {
                this.state = "Read";

            }
            public void Relax()
            {
                this.state = "Relax";
            }
            public void Write()
            {
                this.state = "Write";
            }
            public abstract void Study();
        }

        public class GoodStudent : Student
        {
            public GoodStudent(string name_) : base(name_)
            {
                this.state = "Good";
            }
            public override void Study()
            {
                Read(); Write(); Read(); Write(); Relax();
            }
        }
        public class BadStudent : Student
        {
            public BadStudent(string name_) : base(name_)
            {
                this.state = "Bad";
            }
            public override void Study()
            {
                Relax(); Relax(); Relax(); Relax(); Read();
            }
        }
        public class Group
        {
            string GroupName;

            List<Student> StudentList = new List<Student>();

            public Group(string name)
            {
                GroupName = name;
            }

            public void AddStudent(Student student)
            {
                StudentList.Add(student);
            }
            public void GetInfo()
            {
                Console.WriteLine("Group name: {0}", GroupName);

                foreach (Student student in StudentList)
                {
                    Console.WriteLine(student.name);
                }

            }
            public void GetFullInfo()
            {
                Console.WriteLine("Group name: {0}", GroupName);

                foreach (Student student in StudentList)
                {
                    Console.WriteLine(student.name + " - " + student.state);
                }
            }
        }
        static void Main(string[] args)
        {
            List<Group> GroupList = new List<Group>();
            string GroupName;
            string Name;
            string status;
            while (true)
            {
                Console.Write("Tell me group's name (or 'stop' to stop): ");
                GroupName = Console.ReadLine();
                if (GroupName == "stop") break;
                Group group = new Group(GroupName);
                while (true)
                {
                    Console.Write("Tell me student's name (or 'stop' to stop): ");
                    Name = Console.ReadLine();
                    if (Name == "stop") break;
                    Console.Write("Is this student good or bad  (or 'stop' to stop): ");
                    status = Console.ReadLine();
                    while (!(status == "bad" || status =="good" )) {
                        status = Console.ReadLine();
                    }
                    if (status == "stop") break;
                    if (status == "good")
                    {
                        group.AddStudent(new GoodStudent(Name) { });
                    }
                    else group.AddStudent(new BadStudent(Name) { });
                }   
                GroupList.Add(group);

            }
            foreach(Group group in GroupList)
            {
                group.GetFullInfo();
                Console.WriteLine();
            }
        }
    }
}
