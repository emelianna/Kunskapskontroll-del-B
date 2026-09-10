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

    public void Enroll(Student newStudent) //Lägger till student
    {
        if (!Students.Contains(newStudent) && MaxSeats - Students.Count > 0) //Bara om personen inte redan är med
                                                                                //och om det finns platser kvar
        {
            Students.Add(newStudent); //Ny student läggs till i studentlistan
            newStudent.Join(this); //Anropar studentens Join-metod, som lägger till kursen i studentens Courses-lista     
        }
    }

    public void Remove(Student oldStudent) //Tar bort student
    {
        if (Students.Contains(oldStudent))
        {
           Students.Remove(oldStudent); //Studenten tas bort ur kursens egen studentlista
           oldStudent.Leave(this); //Anropar studentens Leavemetod som tar bort kursen ur studentens kurslista
        }
    }

    public void RollCall() //Listar studenter som läser kursen
    {
        Console.WriteLine("Studerande i denna kurs är:");

        foreach (Student student in Students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }

    public override string ToString() //Gör ett objekt utskrivbart genom att skriva över en metod som redan finns
    {
        return $"{Name} ( {MaxSeats - Students.Count} av {MaxSeats} platser)";
    }
}