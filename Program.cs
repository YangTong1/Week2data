// See https://aka.ms/new-console-template for more information
using Week2data;


Console.WriteLine("Hello, World!");
Student student = new Student();
student.Address = "new lynn";
student.DOB = "31/05/1991";
student.FirstNames = "Yang";
student.Gender = "male";
student.Lastname = "Tong";
string a = student.studentinfo();
Console.WriteLine(a);

Student Anotherstudent = new Student("1234");
Anotherstudent.RegisterPaper("6426");
LinkedList linkedList = new LinkedList();
linkedList.AddNode(422);
linkedList.AddNode(375);
linkedList.AddNode(765);
Console.WriteLine(linkedList.ToString());
Console.WriteLine(linkedList.Length);
Console.WriteLine(linkedList.Min);
Console.WriteLine(linkedList.Max);