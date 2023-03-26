namespace Homework3;

public abstract class Doctor
{
    public string Name { get; }
    public int Age { get; }
    public string Speciality { get; }
    protected int AbilityToCure;
    
    public Doctor(string name, int age, string speciality)
    {
        Name = name;
        Age = age;
        Speciality = speciality;
        AbilityToCure = GetAbilityToCure();
    }

    public abstract void DisplayInfoAboutDoctor();
    public abstract int GetAbilityToCure();
    
    public void ExaminationOfPatient (Doctor doctor, Patient patient)
    {
        if (patient.SymptomToInt == 0)
        {
            patient.DisplayInfo();
            Console.WriteLine($"По результатам обследования - здоров! Осматривал врач: {doctor.Name}, {doctor.Speciality}\n");
        }
        else
        {
            patient.DisplayInfo();
            Console.WriteLine($"У вас обнаружен симптом, начинаем лечение!");
            Cure(doctor, patient);
        }
    }

    public void Cure(Doctor doctor, Patient patient)
    {
        Console.WriteLine($"Вас лечит врач: {doctor.Name}, {doctor.Age}");
        if (doctor.AbilityToCure == patient.SymptomToInt)
            Console.WriteLine("Врач успешно вылечил пациента\n");
        else
        {
            Console.WriteLine("Данный специалист не смог помочь пациенту...");
            doctor.DisplayInfoAboutDoctor();
            Console.WriteLine("Обратитесь к другому специалисту.\n");
        }
    }

}