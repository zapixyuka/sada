using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Model
{
    class TTeacher
    {
        string surname;
        string name;
        string function;
        DateTime today;
        DateTime DateBirthday;
        DateTime DateHiring;
        public TTeacher(string surname, string name, string function, DateTime today, DateTime DateBirthday, DateTime DateHiring)        
        {
            this.surname = surname;
            this.name = name;
            this.function = function;
            this.today = today;
            this.DateBirthday = DateBirthday;
            this.DateHiring = DateHiring;
        }
        public string Surname
        {
            get
            {                
                return surname;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public string Function
        {
            get
            {
                return function;
            }
        }
        public int TeacherAge
        {
            get
            {                
                int age = today.Year - DateBirthday.Year;
                age = (today.Month < DateBirthday.Month) ? age-- : age;
                return age;
            }
        }
        public int TeacherExp
        {
            get
            {
                int exp = today.Year - DateHiring.Year;
                exp = (today.Month < DateHiring.Month) ? exp-- : exp;
                return exp;
            }
        }
        public string Show()
        {            
            string txt = $"Должность: {function}\n";
            txt += $"Фамилия: {surname}\n";
            txt += $"Имя: {name}\n";
            txt += $"Возраст: {TeacherAge} г.\n";
            txt += $"Стаж: {TeacherExp} г.\n";
            return txt;
        }

    }
}
