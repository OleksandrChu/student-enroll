namespace InternshipTest.Person
{
    public class Student
    {
        string name;
        Knowledge knowledge;
        public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, Knowledge knowledge)
        {
            this.name = name;
            this.knowledge = knowledge;
        }

        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = knowledge;
        }

        public int GetKnowledgeLevel() => knowledge.GetLevel();

        public string GetName() => name;
    }
}