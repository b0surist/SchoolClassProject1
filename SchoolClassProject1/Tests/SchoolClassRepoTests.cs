using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassProject.Tests
{
    [TestClass()]
    public class SchoolClassRepoTests
    {
        [TestMethod()]
        public void MostPaydOneSchoolClassTest()
        {
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
                new List<SchoolClass>
                {
                    new SchoolClass(9, "a", 7000, 30)
                });
            string result = schoolClassRepo.MostPaydSchoolClass();
            string expected = "9. a";
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void MostPaydTwoSchoolClassDifferentMoneyTest()
        {
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
                new List<SchoolClass>
                {
                    new SchoolClass(9, "a", 7000, 30),
                    new SchoolClass(9, "b", 6000, 30)
                });
            string result = schoolClassRepo.MostPaydSchoolClass();
            string expected = "9. a";
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void MostPaydTwoSchoolClassSameMoneyTest()
        {
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(
                new List<SchoolClass>
                {
                    new SchoolClass(9, "a", 7000, 30),
                    new SchoolClass(9, "b", 7000, 30)
                });
            string result = schoolClassRepo.MostPaydSchoolClass();
            string expected = "9. a";
            Assert.AreEqual(expected, result);
        }
        [TestMethod()]
        public void MostPaydNoneSchoolClassTest()
        {
            SchoolClassRepo schoolClassRepo = new SchoolClassRepo(new List<SchoolClass>{});
            string result = schoolClassRepo.MostPaydSchoolClass();
            string expected = null;
            Assert.AreEqual(expected, result);
        }
    }
}