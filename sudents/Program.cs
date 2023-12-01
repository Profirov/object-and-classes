﻿int countStudent = int.Parse(Console.ReadLine());
List<Student>students = new List<Student>();

for (int count = 1; count <= countStudent; count++)
{ 
    String data = Console.ReadLine();
    string[] dataParts = data.Split(" ");
    string firstName = dataParts[0];
    string lastName = dataParts[1];
     double grade = double.Parse(dataParts[2]);

    Student student = new Student(firstName, lastName, grade);
    students.Add(student);
}

students = students.OrderByDescending(s => s.Grade).ToList();

foreach (Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}