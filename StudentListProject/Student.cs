namespace StudentListProject
{
    public class Student
    {
        int id;
        string name;
        int age;
        private static int studentCount = 0;

        public Student()
        {
            id = studentCount;
            name = "John Doe";
            age = 16;
            studentCount++;

        }

        public Student( string name, int age)
        {
            this.id = studentCount;
            this.name = name;
            this.age = age;
            studentCount += 1;
        }

        public void Display(int id, string name, int age)
        {
            Console.WriteLine($"{id}, {name}, {age}");
        }
    }
}
