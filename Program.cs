
using DependencyInjectionPractice;

class Program
{
    //Her iki sınıfın metotlarını kullanarak bir
    //Classroom nesnesi oluşturun ve öğretmenin bilgilerini ekrana yazdırın.
    static void Main(string[] args)
    {
        var teacher = new TeacherClass("John", "Doe");

        var classRoom = new ClassRoom(teacher);
        Console.WriteLine("Teacher's Info: " + classRoom.GetTeacherInfo());

        // Output: Teacher's Info: John Doe
    }
}

