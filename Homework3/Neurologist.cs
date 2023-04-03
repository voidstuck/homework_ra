namespace Homework3;

public class Neurologist : Doctor
{
    public Neurologist(string name, int age, Speciality speciality) : base(name, age, speciality) { }

    public override void DisplayInfoAboutDoctor()
    {
        Console.WriteLine($"{Name}, {Age} - {SpecialityToRus()}. Эти врачи лечат самые разнообразные болезни нервной системы");
    }

    public override void Cure(Doctor doctor, Patient patient)
    {
        Console.WriteLine($"Вас лечит врач: {doctor.Name}, {doctor.Age}");
        if (patient.SymptomP == Patient.Symptom.Dizziness)
            Console.WriteLine("Врач успешно вылечил пациента\n");
        else
        {
            Console.WriteLine("Данный специалист не смог помочь пациенту...");
            doctor.DisplayInfoAboutDoctor();
            Console.WriteLine("Обратитесь к другому специалисту.\n");
        }
    }
}