namespace Homework3;

public class Neurologist : Doctor
{
    public Neurologist(string name, int age, string speciality) : base(name, age, speciality) { }

    public override void DisplayInfoAboutDoctor()
    {
        Console.WriteLine($"{Name}, {Age} - является неврологом. Эти врачи лечат самые разнообразные болезни нервной системы");
    }

    public override int GetAbilityToCure()
    {
        switch (Speciality)
        {
            case "Терапевт" : AbilityToCure = 1;
                break;
            case "Гастроэнтеролог" : AbilityToCure = 2;
                break;
            case "Невролог" : AbilityToCure = 3;
                break;
            case "Отоларинголог" : AbilityToCure = 4;
                break;
            default: AbilityToCure = 1;
                break;
        }
        return AbilityToCure;
    }
}