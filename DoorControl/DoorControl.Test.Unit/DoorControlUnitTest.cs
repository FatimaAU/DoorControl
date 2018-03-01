using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DoorControl.Test.Unit
{
    [TestFixture]
    public class DoorControlUnitTests
    {
        //private xxx _uut;

        [SetUp]
        public void Setup()
        {
            //_uut = new xxx();
        }

        [TestCase(3, 2, 5)]
        [TestCase(3, -2, 1)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(a + b, Is.EqualTo(result));
        }
    }
}
