using System.Collections.Generic;
using System.Linq;

namespace DemoITI.Models
{
    public class StudentSampleData
    {
        List<Student> Students = new List<Student>();
        public StudentSampleData() {
            Students.Add(new Student() { Id = 1, Name = "Heba Adel Ahmed", Address = "Cairo", Image = "1.jpg" });
            Students.Add(new Student() { Id = 2, Name = "Thanaa Ahmed", Address = "Cairo", Image = "2.jpg" });
            Students.Add(new Student() { Id = 3, Name = "Mohammed Moataz", Address = "Giza", Image = "3.jpg" });
            Students.Add(new Student() { Id = 1, Name = "Asmaa Ali", Address = "Cairo", Image = "4.jpg" });
            Students.Add(new Student() { Id = 1, Name = "Ahmed Ali", Address = "Cairo", Image = "1.jpg" });
            Students.Add(new Student() { Id = 1, Name = "Ahmed EzzEldin", Address = "Cairo", Image = "2.jpg" });
        }

        public List<Student> GetAll()
        {
            return Students;
        }

        public Student GetById(int id)
        {
            Student student = Students.FirstOrDefault<Student>(S => S.Id == id);
            return student;
        }
    }
}
