ClassManager classManager = new ClassManager();
Teacher t = new Teacher(classManager);
classManager.Teacher = t;

Student s1 = new Student(classManager);
Student s2 = new Student(classManager);
s1.Name = "Ege";
s2.Name = "Gelen";

classManager.AddStudent(s1);
classManager.AddStudent(s2);

s1.SendMessage("How To Solve x2 = y?");
t.SendMessage("Do Your Homeworks");




public interface Mediator
{
    public void SendMessage(Component sender, string message);
    public void RecieveMessage(Component reciever, string message);
}



public class ClassManager:Mediator
{
    private List<Student> _students = new List<Student>();
    private Teacher _teacher;

    public Teacher Teacher { get => _teacher; set => _teacher = value; }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void SendMessage(Component sender, string message)
    {
        if (sender is Teacher) {
            foreach (var student in _students)
            {
                student.RecieveMessage(message);
            }
        }else if(sender is Student)
        {
            _teacher.RecieveMessage(message);
        }

    }
    public void RecieveMessage(Component reciever, string message)
    {
        if (reciever is Teacher)
        {
            Console.WriteLine("Techer Recieved A Message: "+ message);
        }
        else if (reciever is Student)
        {
            Console.WriteLine("Your Teacher Shared A Message With You "+ ((Student)reciever).Name + " :" + message);
        }
    }
}



public abstract class Component
{
    protected Mediator _mediator;
    public Component(Mediator mediator)
    {
        this._mediator = mediator;
    }
    public abstract void SendMessage(string message);
    public abstract void RecieveMessage(string message);

   
}

public class Teacher : Component
{
    public Teacher(Mediator mediator) : base(mediator)
    {
    }

    public override void RecieveMessage( string message)
    {
        _mediator.RecieveMessage(this, message);
    }

    public override void SendMessage(string message)
    {
        _mediator.SendMessage(this, message);
    }
}

public class Student : Component
{
    public string Name { get; set; }
    public Student(Mediator mediator) : base(mediator)
    {
    }

    public override void RecieveMessage(string message)
    {
        _mediator.RecieveMessage(this, message);
    }

    public override void SendMessage(string message)
    {
        _mediator.SendMessage(this, message);
    }
}