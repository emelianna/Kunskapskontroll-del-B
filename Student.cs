class Student
{
    public string Name;     //fält

    public Student(string name) //Konstruktorn, returnerar inget. Fyller i objektets fält med startvärden
    {
        Name = name;
    }

    /*Primary constructor. Alternativt snabbare sätt än ovan 
   
       class Student(string name) 
    {
       public string Name = name;
    }*/

    public List<Course> Courses = []; //Lista med kurser

    public void Join(Course newCourse) 
    {
        if (!Courses.Contains(newCourse))
        {
            Courses.Add(newCourse); //Ny kurs läggs till i kurslistan
            newCourse.Enroll(this); //Lägger till studenten i kursens studentlista (synkar andra hållet)
        }
    }
    public void Leave(Course oldCourse)
{
    if (Courses.Contains(oldCourse))
    {
    Courses.Remove(oldCourse); //Kursen tas bort ur studentens egen kurslista
    oldCourse.Remove(this); //Anropar kursens Removemetod som tar bort studenten ur kursens studentlista
    }
}

public void Schedule()
    {
        Console.WriteLine($"{Name} går dessa kurser: ");

        foreach (Course course in Courses)
        {
            Console.WriteLine($"- {course.Name}");
        }
    }
}


