int[] studentGrade = { 88, 76, 98, 67 };
regular.Student student = new regular.Student("Indu", studentGrade);
double average = student.CalculateAverage();
Console.WriteLine($"{student.studentName}'s average grade is {average}");
