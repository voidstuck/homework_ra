namespace Homework3;

public class Patient
{
    public string Name { get; }
    public int Age { get; }
    public string Symptom { get; }
    public int SymptomToInt;
    
    public int GetSymptomToInt() 
    {
        switch (Symptom)
        {
            case "Кашель" : SymptomToInt = 1;
                break;
            case "Тошнота" : SymptomToInt = 2;
                break;
            case "Головокружение" : SymptomToInt = 3;
                break;
            case "Снижение слуха" : SymptomToInt = 4;
                break;
            default: SymptomToInt = 0;
                break;
        }
        return SymptomToInt;
    }
    
    public Patient(string name, int age, string symptom)
    {
        Name = name;
        Age = age;
        Symptom = symptom;
        SymptomToInt = GetSymptomToInt();
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Пациент {Name}, {Age}, жалуется на симптом {Symptom}");
    }

}