using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPractice
{
    //Ogretmen sınıfı için bir Base Interface oluşturmayı unutmayın. IOgretmen
    public interface ITeacher
    {
        string Teach();
    }

    public class TeacherClass : ITeacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public TeacherClass(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetInfo()
        {
            return $"{FirstName} {LastName}";
        }
        public string Teach()
        {
            return "Teacing Students!";
        }
    }
}
