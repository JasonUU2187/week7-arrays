using StudentListProject;

List<Student> students = new List<Student>;

for  (int i = 0; i < 5; i++)
{
    Console.WriteLine("Enter a name: ");
    string name = (Console.ReadLine());

    Console.WriteLine("Enter an age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Student student = new Student(name, age);
    students.Add(student);
    

}