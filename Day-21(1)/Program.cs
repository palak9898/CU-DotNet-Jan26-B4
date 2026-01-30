using System.Data;

class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public int Marks { get; set; }

    public Student(string name, int id, int marks)
    {
        Name = name;
        Id = id;
        Marks = marks;
    }
    public override string ToString()
    {
        return $"Id - {Id} Marks - {Marks} Name - {Name}";
    }

}
class StudentManager
{
    Dictionary<int,Student> studentsData = new Dictionary<int, Student>();
    public bool AddStudent(Student student)
    {
        int id = student.Id;
        if(!studentsData.ContainsKey(id)){

            studentsData.Add(id, student);
            return true;
        }
        else

        return false;

    }
    public void DisplayAllStudents()
    {
        foreach(var student in studentsData)
        {
            Console.WriteLine(student.Value);
        }
    }
    public bool UpdateStudent(int id, int marks)
    {
        Student foundStudent = SearchStudent(id);
        if (foundStudent != null)
        {
            foundStudent.Marks = marks;
            return true;
        }    
        return false;
    }
    public bool DeleteStudent(int id)
    {
        return studentsData.Remove(id);
    }
    public Student SearchStudent(int id)
    {
        Student student =  null;
        bool found  = studentsData.TryGetValue(id, out student);
        return student;
    }
}
class Day212
{
    static void Main(string[] args)
    {
        StudentManager manager = new StudentManager();

        while (true)
        {
        Console.WriteLine("Menu for Student management");
        Console.WriteLine("Chose any 1 Option: enter option number");
        Console.WriteLine("1. Add student details");
        Console.WriteLine("2. Search student detail");
        Console.WriteLine("3. Update student detail");
        Console.WriteLine("4. Delete student details");
        Console.WriteLine("5. Display student details");
        Console.WriteLine("6. Exit");
        int option = int.Parse(Console.ReadLine());
        
        switch (option)
        {
            case 1:
                {
                    Console.WriteLine("Enter student name: ");
                    string inputName = Console.ReadLine();
                    Console.WriteLine("Enter student Id: ");
                    int inputId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter student Marks: ");
                    int inputMarks = int.Parse(Console.ReadLine());
                    manager.AddStudent(new Student(inputName,inputId, inputMarks));
                    break;
                }
            case 2:
                {
                    Console.WriteLine("Enter id to search");
                    int inputId = int.Parse(Console.ReadLine());
                    Student foundStudent = manager.SearchStudent(inputId);
                    if(foundStudent == null)
                    {
                        Console.WriteLine($"student with {inputId} not found");
                    }
                    else{
                        Console.WriteLine(foundStudent);
                    }
                    break;
                }
            case 3:
                {
                    Console.WriteLine("Enter Id which you want to update marks: ");
                    int inputIdForUpdation = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter marks:");
                    int inputMarksAfterUpdation = int.Parse(Console.ReadLine());
                    bool updated = manager.UpdateStudent(inputIdForUpdation, inputMarksAfterUpdation);
                    if(updated)
                    {
                        Console.WriteLine(manager.SearchStudent(inputIdForUpdation));
                    }
                    break;
                }
            case 4:
                {
                    Console.WriteLine("Enter Id which you want to delete record: ");
                    int inputIdForDeletion = int.Parse(Console.ReadLine());
                    bool deleted = manager.DeleteStudent(inputIdForDeletion);
                    if(deleted)
                    {
                        Console.WriteLine("Student Deleted");
                    }
                    break;
                }
            case 5:
                {
                    manager.DisplayAllStudents();
                    break;
                }
            case 6:
                {
                    return;
                }
            default:
                {
                    Console.WriteLine("Wrong option chosen");
                    break;
                }
        }
        }
    }
    
}
