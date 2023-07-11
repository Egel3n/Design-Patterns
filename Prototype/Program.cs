Student student1 = new Student { Id = 1, Name = "Ege", No = 441 };
Student student2 =(Student) student1.Clone();
student2.Name = "Gelen";

Console.WriteLine(student1.Name + " " + student2.Name);



abstract class Person
{

    public Person(Person p)
    {
        this.Name = p.Name;
        this.Id = p.Id;
    }

    public Person() { }

    public string Name { get; set; }
    public int Id { get; set; }

    public abstract Person Clone();
}

class Student: Person
{
    public int No { get; set; }
    public Student(Student s):base(s)
    {
        this.No = s.No;
    }

    public Student() { }

    public override Person Clone()
    {
        return (Person) new Student(this);
    }
}