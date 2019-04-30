using InternshipTest.Person;
using System;

namespace InternshipTest.Institution
{
    public class University
    {
        private string nameUniversity;
        public Student[] students = new Student[0];

        public University(string name)
        {
            nameUniversity = name;
        }

        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public void AddStudent(string name, string knowledgeLevel)
        {
            Student student = new Student(name, knowledgeLevel);
            AddStudent(student);
        }

        public Student[] SearchInterns()
        {
            Student[] interns = new Student[0];
            int sumKnowledge = 0;
            foreach (Student student in students)
            {
                sumKnowledge += student.knowledgeLevel;
            }
            float average = (float)sumKnowledge / students.Length;

            foreach (Student student in students)
            {
                if (student.knowledgeLevel >= average)
                {
                    Array.Resize(ref interns, interns.Length + 1);
                    interns[interns.Length - 1] = student;
                }
            }
            return interns;
        }
    }
}
