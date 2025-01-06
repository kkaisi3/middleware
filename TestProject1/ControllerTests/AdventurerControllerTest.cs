using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adventure.Controllers;
using Adventure.Repository;
using Adventure.Services;
using FluentAssertions;
using Moq;
using Adventure;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1.ControllerTests
{


    public class Tests
        {
        private Mock<IAdventurerService> _adventurerServiceMock;
        private AdventurerController _adventurerController;
            [SetUp]
            public void Setup()
            {
            _adventurerServiceMock = new Mock<IAdventurerService>();
            _adventurerController = new AdventurerController(_adventurerServiceMock.Object);
            }

            [Test]
            public void Test1()
            {
            List<Adventurer> testAdv = [];
            testAdv.Add( new Adventurer("Gup", Adventurer.ClassType.Warrior) ) ;

            _adventurerServiceMock.Setup(x => x.ReadAdventurers()).Returns(testAdv);

            var result = (OkObjectResult)_adventurerController.ReadAdventurers();

            result.Value.Should().BeEquivalentTo(testAdv);
            
            }
        }
    
}
