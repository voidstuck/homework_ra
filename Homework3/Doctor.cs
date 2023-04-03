namespace Homework3;

public abstract class Doctor
{
    public enum Speciality
    {
        Therapeutist = 1,
        Gastroenterologist = 2,
        Neurologist = 3,
        Otolaryngologist = 4
    }

    public string Name { get; }

    public int Age { get; }
    public Speciality SpecialityD { get; }

    public Doctor(string name, int age, Speciality speciality)
    {
        Name = name;
        Age = age;
        SpecialityD = speciality;
    }

    public abstract void DisplayInfoAboutDoctor();
    protected string SpecialityToRus()
    {
        string rusSpec;
        switch (SpecialityD)
        {
            case Speciality.Gastroenterologist:
                rusSpec = "Гастроэнтеролог";
                break;
            case Speciality.Neurologist:
                rusSpec = "Невролог";
                break;
            case Speciality.Otolaryngologist:
                rusSpec = "Отоларинголог";
                break;
            case Speciality.Therapeutist:
                rusSpec = "Терапевт";
                break;
            default:
                rusSpec = "Неизвестно";
                break;
        }
        return rusSpec;
    }

    public void ExaminationOfPatient(Doctor doctor, Patient patient)
    {
        if (patient.SymptomP == Patient.Symptom.Nothing)
        {
            patient.DisplayInfo();
            Console.WriteLine(
                $"По результатам обследования - здоров! Осматривал врач: {doctor.Name}, {SpecialityToRus()}\n");
        }
        else
        {
            patient.DisplayInfo();
            Console.WriteLine($"У вас обнаружен симптом, начинаем лечение!");
            Cure(doctor, patient);
        }
    }

    public abstract void Cure(Doctor doctor, Patient patient);
}