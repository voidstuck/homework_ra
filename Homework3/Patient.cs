namespace Homework3;

public class Patient
{
    public enum Symptom
    {
        Nothing = 0,
        Cough = 1,
        Sickness = 2,
        Dizziness = 3,
        HearingLoss = 4
    }

    public string Name { get; }
    public int Age { get; }

    public Symptom SymptomP { get; }

    public Patient(string name, int age, Symptom symptom)
    {
        Name = name;
        Age = age;
        SymptomP = symptom;
    }

    protected string SymptomToRus()
    {
        string rusSymptom;
        switch (SymptomP)
        {
            case Symptom.Cough:
                rusSymptom = "Кашель";
                break;
            case Symptom.Dizziness:
                rusSymptom = "Головокружение";
                break;
            case Symptom.Sickness:
                rusSymptom = "Тошнота";
                break;
            case Symptom.HearingLoss:
                rusSymptom = "Снижение слуха";
                break;
            case Symptom.Nothing:
                rusSymptom = "Жалоб нет";
                break;
            default:
                rusSymptom = "Неизвестно";
                break;
        }
        return rusSymptom;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Пациент {Name}, {Age}, жалуется на симптом: {SymptomToRus()}");
    }
}