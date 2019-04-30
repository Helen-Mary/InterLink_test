using InternshipTest.Person;
using System;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        public string nameInternship;
        private Student[] interns;

        public Internship(string name)
        {
            nameInternship = name;
            interns = new Student[0];
        }

        public void FormInterns(University university)
        {
            foreach (Student student in university.SearchInterns())
            {
                Array.Resize(ref interns, interns.Length + 1);
                interns[interns.Length - 1] = student;
            }
        }

        public string GetStudents()
        {
            string namesIntern = "";
            foreach (Student student in interns)
            {
                namesIntern += student.name + "\n";

            }
            return namesIntern;
        }
    }
}
