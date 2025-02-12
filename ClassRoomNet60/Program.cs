using ClassRoomNet60;

class Program
{
    static void Main()
    {
        ClassRoom myClass = new ClassRoom
        {
            ClassName = "3Q",
            SemesterStart = new DateTime(2019, 8, 26)
        };


        myClass.StudentList.Add(new Student("Kasper Larsen", 5, 15));
        myClass.StudentList.Add(new Student("Lars Hasen", 3, 22));
        myClass.StudentList.Add(new Student("Sofie Jensen", 7, 8));


        Console.WriteLine($"Class Name: {myClass.ClassName}");
        Console.WriteLine($"Semester Start: {myClass.SemesterStart.ToShortTimeString()}");
        Console.WriteLine("Students:");
        foreach (var student  in myClass.StudentList)
        {
            Console.WriteLine($"  {student.Name},       Born:   {student.BirthMonth}/{student.Birthday}");
        }


    }

}