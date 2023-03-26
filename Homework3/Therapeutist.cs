namespace Homework3;

public class Therapeutist : Doctor
{
    public Therapeutist(string name, int age, string speciality) : base(name, age, speciality) { }
    
    public override void DisplayInfoAboutDoctor()
    {
        Console.WriteLine($"{Name}, {Age} - терапевт. Терапевты - это врачи шикорого профиля с большой насмотренностью на разные симптомы");
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