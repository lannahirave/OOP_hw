using System;

namespace adapter
{
    public class Student
    {
        protected int WantedGrade;

        public int Grade
        {
            get { return WantedGrade; }
            set { WantedGrade = value; }
        }

        public Student(int grade = 95)
        {
            WantedGrade = grade;
        }

        public bool Convince()
        {
            Random rnd = new Random();
            int number = rnd.Next(0, 5);
            //Console.WriteLine(number);
            if (number == 0) return false;
            else return true;
        }
    }

    public class Teacher
    {
        protected int ActualGrade;

        public int Grade
        {
            get { return ActualGrade; }
            set { ActualGrade = value; }
        }
    }

    public interface IGetGrade
    {
        public int GetGrade();
    }
    public class Adapter: IGetGrade
    {
        private Student _student;
        private Teacher _teacher;

        public Adapter(Student student, Teacher teacher)
        {
            _student = student;
            _teacher = teacher;
        }
        
        public int GetGrade()
        {
            var gradeStudent = _student.Grade;
            _teacher.Grade = gradeStudent - 10;
            var gradeTeacher = _teacher.Grade;
            if (gradeStudent == gradeTeacher) return gradeStudent;
            if (_student.Convince())
            {
                _teacher.Grade = gradeStudent;
                gradeTeacher = gradeStudent;
            }
            else _student.Grade = gradeTeacher;

            return gradeTeacher;
        }
    }
}