namespace Homework3;

public class Otolaryngologist : Doctor
{
    public Otolaryngologist(string name, int age, Speciality speciality) : base(name, age, speciality) { }

    public override void DisplayInfoAboutDoctor()
    {
        Console.WriteLine($"{Name}, {Age} - {SpecialityToRus()}. В народе эта специальность известна как ЛОР. Врач лечит ухо, горло, нос");
    }

    public override void Cure(Doctor doctor, Patient patient)
    {
        Console.WriteLine($"Вас лечит врач: {doctor.Name}, {doctor.Age}");
        if (patient.SymptomP == Patient.Symptom.HearingLoss)
            Console.WriteLine("Врач успешно вылечил пациента\n");
        else
        {
            Console.WriteLine("Данный специалист не смог помочь пациенту...");
            doctor.DisplayInfoAboutDoctor();
            Console.WriteLine("Обратитесь к другому специалисту.\n");
        }
    }
}