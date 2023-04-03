namespace Homework3;

public class Gastroenterologist : Doctor
{
    public Gastroenterologist(string name, int age, Speciality speciality) : base(name, age, speciality)
    {
    }

    public override void DisplayInfoAboutDoctor()
    {
        Console.WriteLine($"{Name}, {Age} - {SpecialityToRus()}. Это такие врачи, которые занимаются лечением заболеваний желудочно-кишечного тракта");
    }

    public override void Cure(Doctor doctor, Patient patient)
    {
        Console.WriteLine($"Вас лечит врач: {doctor.Name}, {doctor.Age}");
        if (patient.SymptomP == Patient.Symptom.Sickness)
            Console.WriteLine("Врач успешно вылечил пациента\n");
        else
        {
            Console.WriteLine("Данный специалист не смог помочь пациенту...");
            doctor.DisplayInfoAboutDoctor();
            Console.WriteLine("Обратитесь к другому специалисту.\n");
        }
    }
}