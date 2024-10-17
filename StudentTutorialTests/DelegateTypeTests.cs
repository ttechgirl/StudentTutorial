using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentTutorial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTutorial.Tests
{
    [TestClass()]
    public class DelegateTypeTests
    {

        [TestMethod()]
        public void CalculatorTest()
        {
            //arrange
            DelegateType delegateType = new DelegateType(); //sut
            //act
            var del = delegateType.Countries(6, Countries.CANADA);
            //assert
            Assert.IsNotNull(del);
            //Assert.That.Equals(del);
        }

    }
}