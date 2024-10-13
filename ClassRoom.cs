using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionPractice
{
    internal class ClassRoom
    {
        public TeacherClass Teacher { get; }


        //ClassRoom sınıfının yapıcısına (constructor) Teacher sınıfının bir
        //örneğini (instance) parametre olarak geçin. (Constructor Injection)
        public ClassRoom(TeacherClass teacher)
        {
            Teacher = teacher;
        }

        public string GetTeacherInfo()
        {
            return Teacher.GetInfo();
        }


    }
}
