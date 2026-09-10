class Course
{
    public string Name;     //fält 
    public int MaxSeats;    

    public Course(string name, int maxSeats) //Konstruktorn, returnerar inget. Fyller i objektets fält med startvärden
    {
        Name = name;
        MaxSeats = maxSeats;
    }


    public List<Student> students = []; //Lista med studenter



    public void Enroll(Student newStudent) //Lägger till student
    {
         if (!students.Contains(newStudent) && MaxSeats - students.Count > 0) //Bara om personen inte redan är med
                                                                               //och om det finns platser kvar  
        {
            students.Add(newStudent);
            // oldStudent.Join(this); //Senare, när metoden Join är skapad i Student-klassen
           
        }
    }
    public void Remove(Student oldStudent) //Tar bort student
    {
         if (students.Contains(oldStudent))

        {
              students.Remove(oldStudent);
            // newStudent.Leave(this); //Senare, när metoden Leave är skapad i Student-klassen
        }
    }

    public void RollCall()
    {
        Console.WriteLine("Studerande i denna kurs är:");

        foreach (Student student in students)
        {
           Console.WriteLine($"- {student.Name}");
        }

    
}
    

    public override string ToString()
    {
        return $"{Name} ( {MaxSeats - students.Count} av {MaxSeats} platser)";
    }
}