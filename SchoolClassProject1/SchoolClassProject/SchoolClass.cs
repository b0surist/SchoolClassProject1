using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClass
    {
        public int Evfolyam {  get; set; }
        public string OsztalyID {  get; set; }
        public int Penz {  get; set; }
        public int DiakDB { get; set; }

        public SchoolClass(int evfolyam, string osztalyID, int penz, int diakDB)
        { 
            Evfolyam = evfolyam;
            OsztalyID = osztalyID;
            Penz = penz;
            DiakDB = diakDB;
        }
        public override string ToString()
        {
            return $"{Evfolyam}. {OsztalyID} ({Penz} Ft)";
        }

        public int Osszes()
        {
            return Penz * DiakDB * 10;
        }
    }
}
