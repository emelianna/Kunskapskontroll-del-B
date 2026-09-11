class Course
{
    public string Name;     //fält 
    public int MaxSeats;    

    public Course(string name, int maxSeats) //Konstruktorn, returnerar inget. Fyller i objektets fält med startvärden
    {
        Name = name;
        MaxSeats = maxSeats; 
    }

    public List<Student> Students = [];             //kursens lista med inskrivna studenter 

    public void Enroll(Student newStudent)          //Anropas också och sköter jobbet med att lägga till när Join körs
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
    Students.Add(newStudent);       // En student läggs till i kursens lista med studenter.
    newStudent.Courses.Add(this);   // This syftar på objektet som metoden anropas på. I detta fall kursen eftersom vi är i Course. 
                                    // En kurs (this) läggs till studentens lista. 
    Console.WriteLine($"{newStudent.Name} är tillagd i kursen {Name}");
}
}



public void Remove(Student oldStudent)      //Anropas också och sköter jobbet med att ta bort när Leave körs
{
    if (Students.Contains(oldStudent))
    {
        Students.Remove(oldStudent);        // kursen tar bort student ur sin egen lista (Students)
        oldStudent.Courses.Remove(this);    // studenten får kursen (this) borttagen ur sin lista (Courses)
        Console.WriteLine($"{oldStudent.Name} är borttagen från kursen {Name}");
    }
    else
    {
        Console.WriteLine($"{oldStudent.Name} är inte inskriven i kursen {Name} och kan därför inte tas bort");
    }
}

    public void RollCall() //Listar studenter som läser kursen
    {
if (Students.Count == 0)
        {
            Console.WriteLine($"Det är ingen som går kursen {Name} för tillfället. Den är tom. Det finns {MaxSeats} platser lediga");
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
                                      //När Console.WriteLine(kemi); körs visas detta nedan gällande kursen kemi   
    {
        return $"{Name} ( {MaxSeats - Students.Count} av {MaxSeats} platser lediga)";
    }
}