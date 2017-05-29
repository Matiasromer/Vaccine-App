using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Windows.Devices.Input;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using Vaccine_App;
using Vaccine_App.Model;
using Vaccine_App.Persistency;

namespace UnitTest
{
    [TestClass]
    public class BarnUnitTests
    {
        [TestMethod]
        public void TestForName()
        {
            //Tester om Navet er rigtigt når et objekt skabes.
            //arrange
            string expected = "Karl-Egon";
            Barn TestBarn = new Barn("Karl-Egon", 0, DateTime.Now, "Dreng");
            string actual = TestBarn.Barn_Navn;
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForGender()
        {
            //arrange
            //Tester om kønnet er rigtigt
            Barn TestBarn = new Barn("Karla", 0, DateTime.Today.AddDays(2), "Pige");
            string expected = "Pige";
            string actual = TestBarn.Gender;
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForToString()
        {
            //arrange
            Barn TestBarn = new Barn("Pepe", 0, DateTime.Now, "Dreng");
            string expected = $"Pepe   -  {TestBarn.Barn_Foedsel:dd/MM/yyyy} -  Dreng  ";
            string actual = TestBarn.ToString();
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestForBirth()
        {
            //arrange
            //Tester Birthday - Vil dog teste forkert, da Actual date er sat til Now, mens expected er sat til noget helt andet.
            Barn TestBarn = new Barn("Karla", 0, DateTime.Now, "Pige");
            DateTime expected = DateTime.Now.AddYears(3);
            DateTime actual = TestBarn.Barn_Foedsel;
            //act
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
