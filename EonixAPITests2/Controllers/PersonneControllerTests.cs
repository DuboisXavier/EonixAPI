using EonixAPI.Services;
using EonixEF.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Personne.WebService.Controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Personne.WebService.Controllers.Tests
{
    [TestClass()]
    public class PersonneControllerTests
    {
        PersonneService personneService;

        List<Personnes> simulatedPersonnes = new List<Personnes>();
        Personnes personne1 = new Personnes { Id = 1, Name = "Dubois", FirstName = "Xavier" };
        Personnes personne2 = new Personnes { Id = 2, Name = "Feret", FirstName= "Yohan" };
      
        [TestMethod()]
        public void GetTest()
        {
            //ARRANGE
            IEnumerable<Personnes> actualList;
            simulatedPersonnes.Add(personne1);
            simulatedPersonnes.Add(personne2);
            
            //ACT
            actualList = personneService.GetAllPersonnes();
            //ASSERT
            Assert.AreEqual(simulatedPersonnes, actualList);
        }

        [TestMethod()]
        public void GetTest1()
        {
            Personnes p = new Personnes();

            p = personneService.GetPersonneById(1);
                
            Assert.AreEqual(personne1, p);
        }

        [TestMethod()]
        public void PostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
    }
}

namespace EonixAPITests2.Controllers
{
    class PersonneControllerTests
    {
    }
}
