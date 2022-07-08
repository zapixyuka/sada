using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Курсовая.Model;
namespace Курсовая
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            /*try
            {
                TUniversity university = new TUniversity();
                Console.WriteLine(university.MinMaxExp());
                Console.WriteLine(university.PrizeFromTen());
                Console.WriteLine(university.Sorting());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
        }
    }
}
