using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        string name;
        List<Student> students = new List<Student>();

        public University(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetStudents() => students;

        public int GetAverageKnowlendge()
        {
            int average = 0;
            students.ForEach(student => average += student.GetKnowledgeLevel());
            return average / students.Count;
        }
    }
}
