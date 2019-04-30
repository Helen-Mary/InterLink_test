namespace InternshipTest.Person
{
    public class Student
    {
        public string name;

        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, string knowledgeLevel)
        {
            this.name = name;
            this.knowledgeLevel = int.Parse(knowledgeLevel);
        }

        public int knowledgeLevel;
        public void SetKnowledge(Knowledge knowledge)
        {
            knowledgeLevel = knowledge.level;
        }
    }
}