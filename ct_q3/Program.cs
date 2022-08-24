using System;
using System.Collections.Generic;

public class LanguageStudent 
{ 
    public List<string> _languages = new List<string>();

    public List<string> Languages
    {
        get
        {
            return _languages;
        }  
    }

    public void AddLanguage(string Language) 
    {
        Languages.Add(Language);
    }
}

public class LanguageTeacher : LanguageStudent 
{
    public bool Teach(LanguageStudent student, string language) 
    {
        foreach (var lang in this.Languages)
        {
            if (language == lang)
            {
                student.Languages.Add(language);
                return true;
            }
        }

        return false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LanguageTeacher teacher = new LanguageTeacher();
        teacher.AddLanguage("English");

        LanguageStudent student = new LanguageStudent();
        teacher.Teach(student, "English");

        foreach (var language in student.Languages)
            Console.WriteLine(language);
    }
}