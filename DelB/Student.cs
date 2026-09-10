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
        if (Courses.Contains(newCourse))
        {
            //Console.WriteLine($"{Name} är redan anmäld till {newCourse.Name}");
        }
        else
        {
            //Console.WriteLine($"{Name} är nu inskriven i kursen {newCourse.Name}");
            Courses.Add(newCourse); //Ny kurs läggs till i kurslistan
            newCourse.Enroll(this); //Lägger till studenten i kursens studentlista (synkar andra hållet)
        }
    }
    public void Leave(Course oldCourse)
{
    if (!Courses.Contains(oldCourse))
        {
            //Console.WriteLine($"{Name} är inte inskriven i {oldCourse.Name} och kan därför inte lämna");
        }
        else
    {
    //Console.WriteLine($"{Name} är nu borttagen från kursen {oldCourse.Name}");
    Courses.Remove(oldCourse); //Kursen tas bort ur studentens egen kurslista
    oldCourse.Remove(this); //Anropar kursens Removemetod som tar bort studenten ur kursens studentlista
    }
}

public void Schedule() //Metod som skriver ut vilka kurser den studerande går (om den går några)
    {
if (Courses.Count == 0) 
        {
            Console.WriteLine($"{Name} är inte anmäld till några kurser än.");
        }

        else {

        Console.WriteLine($"{Name} går dessa kurser: ");

        foreach (Course course in Courses)
        {
            Console.WriteLine($"- {course.Name}");
        }
    }
}
public override string ToString() //Gör ett objekt utskrivbart genom att skriva över en metod som redan finns
    {
        return $"{Name}";
    }
}

