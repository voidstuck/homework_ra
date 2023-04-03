/* Задумка: есть врачи разных специальностей, есть пациенты с разными жалобами. У врача есть имя, возраст, специальность.
 У пациента есть имя, возраст и симптомы. Каждый врач лечит только одину систему органов (т.е. один симптом).
 Пациент сам выбирает врача, как бы не зная его специальность, в этом случае врач либо вылечивает пациента (если симптом совпал
 со специальностью), либо отпускает пациента с рекомендацией обратиться к другому врачу, тогда пациент снова выбирает врача.
 */

namespace Homework3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Doctor vrach1 = new Therapeutist("Светлая А.Б.", 45, Doctor.Speciality.Therapeutist);
            Doctor vrach2 = new Gastroenterologist("Мучная Г.Г.", 30, Doctor.Speciality.Gastroenterologist);
            Doctor vrach3 = new Neurologist("Нервный М.Д.", 39, Doctor.Speciality.Neurologist);
            Doctor vrach4 = new Otolaryngologist("Глухарь Д.С.", 27, Doctor.Speciality.Otolaryngologist);
            
            Patient p1 = new Patient("Самойлов Н.Р.", 23, Patient.Symptom.Dizziness);
            Patient p2 = new Patient("Лапина Н.П.", 60, Patient.Symptom.Nothing);
            Patient p3 = new Patient("Тетерин З.М.", 56, Patient.Symptom.Cough);
            Patient p4 = new Patient("Русаков В.Г.", 39, Patient.Symptom.HearingLoss);
            Patient p5 = new Patient("Назарова В.Н.", 19, Patient.Symptom.Sickness);

            vrach1.ExaminationOfPatient(vrach1, p2);
            vrach2.ExaminationOfPatient(vrach2, p1);
            vrach2.ExaminationOfPatient(vrach2, p5);
            vrach3.ExaminationOfPatient(vrach3, p1);
            vrach4.ExaminationOfPatient(vrach4, p4);
            vrach3.ExaminationOfPatient(vrach3, p3);
        }
    }
}
