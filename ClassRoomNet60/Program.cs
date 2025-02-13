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


        myClass.StudentList.Add(new Student("Mikkel Hansen", 2, 10));
        myClass.StudentList.Add(new Student("Sofie Nielsen", 6, 25));
        myClass.StudentList.Add(new Student("Anders Pedersen", 11, 5));
        myClass.StudentList.Add(new Student("Emma Larsen", 8, 17));
        myClass.StudentList.Add(new Student("Frederik Jensen", 4, 3));
        myClass.StudentList.Add(new Student("Olivia Mortensen", 1, 15));
        myClass.StudentList.Add(new Student("Liam Sørensen", 7, 7));
        myClass.StudentList.Add(new Student("Sara Hansen", 3, 22));
        myClass.StudentList.Add(new Student("Noah Madsen", 5, 11));
        myClass.StudentList.Add(new Student("Luca Johansen", 9, 1));
        myClass.StudentList.Add(new Student("Isabella Olesen", 10, 30));
        myClass.StudentList.Add(new Student("Benjamin Schmidt", 12, 12));
        myClass.StudentList.Add(new Student("Kasper Larsen", 5, 15));
        myClass.StudentList.Add(new Student("Lars Hasen", 3, 22));
        myClass.StudentList.Add(new Student("Sofie Jensen", 7, 8));


        Console.WriteLine($"Class Name: {myClass.ClassName}");
        Console.WriteLine($"Semester Start: {myClass.SemesterStart.ToShortDateString()}");
        Console.WriteLine("Students:");
        foreach (var student  in myClass.StudentList)
        {
            Console.WriteLine($"  {student.Name},       Born:   {student.BirthMonth}/{student.Birthday}");
        }

        myClass.CountBirthdaysBySeason();

        Console.ReadKey();
    }

}