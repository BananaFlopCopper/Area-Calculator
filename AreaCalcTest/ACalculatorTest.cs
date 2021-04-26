using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary;

namespace AreaCalcTest
{
    [TestClass]
    public class ACalculatorTest : Base
    {
        [TestMethod]
        public void getSquareArea_StringBased_OneTest()
        {
            setStringOnePair();

            Assert.IsTrue(AreaCalculator.getSquareArea(_one) == _oneArea);
        }
        [TestMethod]
        public void getSquareArea_StringBased_TwoTest()
        {
            setStringTwoPair();

            Assert.IsTrue(AreaCalculator.getSquareArea(_two) == _twoArea);
        }
        [TestMethod]
        public void getSquareArea_StringBased_TenTest()
        {
            setStringTenPair();

            Assert.IsTrue(AreaCalculator.getSquareArea(_ten) == _tenArea);
        }
        [TestMethod]
        public void getSquareArea_StringBased_ZeroTest()
        {
            setStringZeroPair();

            Assert.IsTrue(AreaCalculator.getSquareArea(_zero) == _zeroArea);
        }
        [TestMethod]
        public void getSquareArea_StringBased_ElevenFailTest()
        {
            setStringEleven();
            Assert.IsTrue(AreaCalculator.getSquareArea(_eleven) == 0);
        }
        [TestMethod]
        public void getSquareArea_StringBased_NullFailTest()
        {
            Assert.IsTrue(AreaCalculator.getSquareArea(null) == 0);
        }
        [TestMethod]
        public void getCircleRadius_GoodAreaTest()
        {
            setGoodAreaPair();
            Assert.IsTrue(AreaCalculator.getCircleRadius(_goodArea) == _goodRadius);
        }
        [TestMethod]
        public void getCircleRadius_ZeroAreaTest()
        {
            setStringZeroPair();
            Assert.IsTrue(AreaCalculator.getCircleRadius(_zeroArea) == 0);
        }
    }
}
