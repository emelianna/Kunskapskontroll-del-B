class Course
{
    public string Name;     //fält 
    public int MaxSeats;    

    public Course(string name, int maxSeats) //Konstruktorn, returnerar inget. Fyller i objektets fält med startvärden
    {
        Name = name;
        MaxSeats = maxSeats;
    }

    public List<Student> Students = []; //Lista med studenter

    public void Enroll(Student newStudent)
{
    if (Students.Contains(newStudent))
    {
        Console.WriteLine($"{newStudent.Name} är redan anmäld till {Name}.");
    }
    else if (MaxSeats - Students.Count <= 0)
    {
        Console.WriteLine($"Tyvärr är {Name} full, {newStudent.Name} kan inte läggas till.");
    }
    else
    {
        Console.WriteLine($"{newStudent.Name} är tillagd i kursen {Name}");
        Students.Add(newStudent);
        newStudent.Join(this);
    }
}

    public void Remove(Student oldStudent) //Tar bort en student
    {
        if (Students.Contains(oldStudent))
        {
           Console.WriteLine($"{oldStudent.Name} är borttagen från kursen {Name}");
           Students.Remove(oldStudent); //Studenten tas bort ur kursens egen studentlista
           oldStudent.Leave(this); //Anropar studentens Leavemetod som tar bort kursen ur studentens kurslista
        }

        else
        {
            Console.WriteLine($"{oldStudent.Name} har inte varit inskriven i kursen {Name} och kan därför inte tas bort");
        }
    }


    public void RollCall() //Listar studenter som läser kursen
    {
if (Students.Count == 0)
        {
            Console.WriteLine($"Det är ingen som går {Name} för tillfället. Den är tom. Det finns {MaxSeats} platser lediga");
        }
        else {

        Console.WriteLine($"Studerande i kurs {Name} är:");

        foreach (Student student in Students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}
    public override string ToString() //Gör ett objekt utskrivbart genom att skriva över en metod som redan finns
    {
        return $"{Name} ( {MaxSeats - Students.Count} av {MaxSeats} platser lediga)";
    }
}