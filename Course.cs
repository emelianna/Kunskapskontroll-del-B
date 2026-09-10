class Course
{
    public string Name;     //fält med klassens egenskaper
    public int MaxSeats;    

    public Course(string name, int maxSeats) //Konstruktorn, returnerar inget
    {
        Name = name;
        MaxSeats = maxSeats;
    }


    public List<Student> students = []; //Lista med studenter



    public void Enroll(Student newStudent)
    {
         if (!students.Contains(newStudent) && MaxSeats - students.Count > 0)

        {
            students.Add(newStudent);
            // newStudent.Leave(this); //Senare, när metoden Leave är skapad i Student-klassen
        }
    }

    public override string ToString()
    {
        return $"{Name} ( {MaxSeats - students.Count} av {MaxSeats} platser)";
    }
}