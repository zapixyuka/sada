using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Курсовая.Model
{
    class TUniversity
    {
        int YearsVed;
        int KolTecher;
        TTeacher[] Teacher;
        public TUniversity()
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + "\\List.txt";
                StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
                string Surname, Name, Function;
                int DayBirthday, MonthBirthday, YearBirthday;
                int DayHiring, MonthHiring, YearHiring;
                DateTime today;
                DateTime DateBirthday;
                DateTime DateHiring;
                YearsVed = int.Parse(sr.ReadLine());
                KolTecher = int.Parse(sr.ReadLine());
                Teacher = new TTeacher[KolTecher];
                sr.ReadLine();
                for (int i = 0; i < Teacher.Length; i++)
                {
                    Surname = sr.ReadLine();
                    Name = sr.ReadLine();
                    Function = sr.ReadLine();
                    today = new DateTime(YearsVed, 1, 1);
                    DayBirthday = int.Parse(sr.ReadLine());
                    MonthBirthday = int.Parse(sr.ReadLine());
                    YearBirthday = int.Parse(sr.ReadLine());
                    DateBirthday = new DateTime(YearBirthday, MonthBirthday, DayBirthday);
                    DayHiring = int.Parse(sr.ReadLine());
                    MonthHiring = int.Parse(sr.ReadLine());
                    YearHiring = int.Parse(sr.ReadLine());
                    DateHiring = new DateTime(YearHiring, MonthHiring, DayHiring);
                    Teacher[i] = new TTeacher(Surname, Name, Function,today ,DateBirthday, DateHiring);
                    sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }       
        public string MinMaxExp()
        {
            string txt = ""; int max = 0, min = 0;
            int MaxExp = Teacher[max].TeacherExp;
            int MinExp = Teacher[min].TeacherExp;
            for (int i = 0; i < Teacher.Length; i++)
            {
                if(MaxExp<= Teacher[i].TeacherExp) 
                {
                    MaxExp = Teacher[i].TeacherExp;
                    max = i;
                }
                if (MinExp >= Teacher[i].TeacherExp) 
                {
                    MaxExp = Teacher[i].TeacherExp;
                    min = i; 
                }
            }
            txt = "Работник с самым большим стажем:\n" + Teacher[max].Show()+"\n";
            txt += "Работник с самым меньшим стажем:\n" + Teacher[min].Show()+"\n";
            return txt;
        }
        public string PrizeFromTen()
        {
            string txt = "Работники представленные к поощрению:\n";
            for (int i = 0; i < Teacher.Length; i++)
            {
                while (Teacher[i].TeacherExp > 10) 
                {
                    txt+= $"{Teacher[i].Function} {Teacher[i].Name} {Teacher[i].Surname}\n";
                    break;
                }                    
            }
            txt += "\n";
            return txt;
        }       
        public string Sorting()
        {
            string txt = "Список преподавателей:\n";
            for(int i = 0; i < Teacher.Length; i++)
            {
                for (int j = i+1; j < Teacher.Length; j++)
                {
                    if (Teacher[i].TeacherAge < Teacher[j].TeacherAge)
                    {
                        (Teacher[i], Teacher[j]) = (Teacher[j], Teacher[i]);
                    }
            
                }
                
            }
            for (int i = 0; i < Teacher.Length; i++)
            {
                txt += $"{Teacher[i].Show()}\n";
            }
            return txt;
        }
    }
}
