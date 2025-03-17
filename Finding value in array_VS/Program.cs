string[] student = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
Console.WriteLine("Enter student name: ");
string studentname = Console.ReadLine();

bool isExist = false;
for (int i = 0; i < student.Length; i++)
{
    if (student[i].Equals(studentname))
    {
        Console.WriteLine("Position of the students in the list " + student[i] + " is: " + (i + 1));
        isExist = true;
        break;
    }
}
if (!isExist)
{
    Console.WriteLine("Not Found " + studentname + " in the list.");
}