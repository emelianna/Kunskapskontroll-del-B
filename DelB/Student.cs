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

    public List<Course> Courses = []; //Studentens lista med kurser

    
    public void Join(Course newCourse) //Fanns mer kod här tidigare, men blev stökigt med fram och tillbaka.
                                       //Nu sköter Course.Enroll och Course.Remove hela jobbet med att lägga till och ta bort 
{                                      //Att metoderna i Course sköter det beror på att MaxSeats finns där.  
    newCourse.Enroll(this);            //"Anropa metoden Enroll på newCourse och skicka med this (studenten) som parameter"
}

public void Leave(Course oldCourse) //Är egentligen bara en väg till metoden Remove. 
{
    oldCourse.Remove(this);         //"Anropa metoden Remove på oldCourse och skicka med this (studenten) som parameter"  
}



public void Schedule() //Metod som skriver ut vilka kurser den studerande går (om den går några)
    {
if (Courses.Count == 0) 
        {
            Console.WriteLine($"{Name} är inte anmäld till några kurser");
        }

        else {

        Console.WriteLine($"{Name} går dessa kurser: ");

        foreach (Course course in Courses)
        {
            Console.WriteLine($"- {course.Name}");
        }
    }
}
public override string ToString() //Gör ett objekt utskrivbart genom att skriva över en metod som redan finns.
                                   //Console.WriteLine(alfons); skriver ut det nedan, alltså i detta fall 
                                   //studenten alfons namn. 
    {
        return $"{Name}";
    }
}

