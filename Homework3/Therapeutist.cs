namespace Homework3;

public class Therapeutist : Doctor
{
    public Therapeutist(string name, int age, Speciality speciality) : base(name, age, speciality) { }

    public override void DisplayInfoAboutDoctor()
    {
        Console.WriteLine($"{Name}, {Age} - {SpecialityToRus()}. Терапевты - это врачи шикорого профиля с большой насмотренностью на разные симптомы");
    }

    public override void Cure(Doctor doctor, Patient patient)
    {
        Console.WriteLine($"Вас лечит врач: {doctor.Name}, {doctor.Age}");
        if (patient.SymptomP == Patient.Symptom.Cough)
            Console.WriteLine("Врач успешно вылечил пациента\n");
        else
        {
            Console.WriteLine("Данный специалист не смог помочь пациенту...");
            doctor.DisplayInfoAboutDoctor();
            Console.WriteLine("Обратитесь к другому специалисту.\n");
        }
    }
}