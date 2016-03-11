using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpassglast
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DateTime[] obj = new DateTime[100];
                int sib;
               
                Console.Out.WriteLine("Enter Siblings");
                sib = Convert.ToInt32(Console.ReadLine());
             
                for (int i = 0; i < sib; i++)
                {
                    Console.Out.WriteLine("Enter Date of Birth");
                    obj[i] = Convert.ToDateTime(Console.ReadLine());
                    int day = (DateTime.Now.Year * 365 + DateTime.Now.Day) - (obj[i].Year * 365 + obj[i].Day);
                    int year = day / 365;
                    int months = (DateTime.Now.Month * 30 + DateTime.Now.Day) - (obj[i].Month * 30 + obj[i].Day);
                    int month = (months % 365) / 30;
                    int days = (day % 365) % 30;
                    Console.Out.WriteLine(Math.Abs(year) + " YEARS " + Math.Abs(month) + " MONTHS " + Math.Abs(days) + " DAYS ");
                }
               

               /*  for (int j = 0; j < sib - 1; j++)
                 {
                     TimeSpan time = obj[j].Subtract(obj[j + 1]);
                     int Days = time.Days;
                     int Year = Days/365;
                     Console.Out.WriteLine("Years = " + Math.Abs(Year));
                     int Month = (Days-(Year*365)/30);
                     Console.Out.WriteLine("Month = " + Math.Abs(Month));
                     int days = (Days %365) % 30;
                     Console.Out.WriteLine("Days = " + Math.Abs(days));
                 }*/

                Console.ReadLine();
            }
            catch(Exception){
                Console.Out.WriteLine("Invalid Input");
                Console.ReadLine();
        }
        
    }
       
    }
}
