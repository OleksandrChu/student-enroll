using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        string name;
        List<Student> enrolledStudents = new List<Student>();
        public Internship(string name)
        {
            this.name = name;
        }

        public string GetStudents()
        {
            string responce = "";
            enrolledStudents.ForEach(student => responce += $"Student {student.GetName()} enrolled in an internship!\n");
            return responce;
        }

        public void SelectStudentsFromUniversity(University university)
        {
            int averageKnowlegleLevel = university.GetAverageKnowlendge();
            university.GetStudents().ForEach(student =>
            {
                if (student.GetKnowledgeLevel() >= averageKnowlegleLevel)
                {
                    enrolledStudents.Add(student);
                }
            });
        }
    }
}
