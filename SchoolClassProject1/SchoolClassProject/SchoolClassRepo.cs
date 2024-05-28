using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject
{
    public class SchoolClassRepo
    {
        public List<SchoolClass> _schoolClass = new List<SchoolClass>();
        
        public void HozzaAD(SchoolClass schoolClass)
        {
            _schoolClass.Add(schoolClass);
        }

        public SchoolClassRepo(List<SchoolClass> schoolClasses)
        {
            _schoolClass = schoolClasses;
        }

        public List<SchoolClass> FinDall() => _schoolClass;

        public string MostPaydSchoolClass()
        {
            if(_schoolClass.Count == 0)
            {
                return null;
            }
            else
            {
                var legtobb = _schoolClass.OrderByDescending(sc => sc.Penz).FirstOrDefault();
                return $"{legtobb.Evfolyam}. {legtobb.OsztalyID}"; 
            }
        }
    }
}
