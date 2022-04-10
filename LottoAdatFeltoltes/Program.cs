using LottoAdatKapcsolatt.Data;
using LottoAdatKapcsolatt.Models;
using System;
using System.IO;
using System.Linq;

namespace LottoAdatFeltoltes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LottoSzamContext db = new LottoSzamContext();
            if (!db.LottoSzamok.Any())
            {
            string[] sorok = File.ReadAllLines(@"C:\Users\David\Desktop\SkandinavLottoSzamok.csv");
                LottoSzam lsz = null;
                foreach (string sor in sorok)
                {
                    bool sikerult = true;
                    try
                    {
                        lsz = new LottoSzam(sor);
                    }
                    catch (Exception)
                    {

                        sikerult = false ;
                    }
                    if (sikerult) db.LottoSzamok.Add(lsz);
                }
                db.SaveChanges();
                
            }
        }
    }
}
