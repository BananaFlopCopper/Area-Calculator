using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalcTest
{
    public class Base
    {
        public TestContext TestContext { get; set; }

        // string Area variables
        protected string _one;
        protected int _oneArea;
        
        protected string _two;
        protected int _twoArea;
        
        protected string _ten;
        protected int _tenArea;
        
        protected string _zero;
        protected int _zeroArea;
        
        protected string _eleven;

        // getCircleRadius variables
        protected int _goodArea;
        protected double _goodRadius;

        protected int _zeroRadius;

        // string area sets
        protected void setStringOnePair()
        {
            _one = TestContext.Properties["One"].ToString();
            _oneArea = int.Parse(TestContext.Properties["OneArea"].ToString());
        }
        protected void setStringTwoPair()
        {
            _two = TestContext.Properties["Two"].ToString();
            _twoArea = int.Parse(TestContext.Properties["TwoArea"].ToString());
        }
        protected void setStringTenPair()
        {
            _ten = TestContext.Properties["Ten"].ToString();
            _tenArea = int.Parse(TestContext.Properties["TenArea"].ToString());
        }
        protected void setStringZeroPair()
        {
            _zero = TestContext.Properties["Zero"].ToString();
            _zeroArea = int.Parse(TestContext.Properties["ZeroArea"].ToString());
        }
        protected void setStringEleven()
        {
            _eleven = TestContext.Properties["Eleven"].ToString();
        }

        // circleRadius sets
        protected void setGoodAreaPair()
        {
            _goodArea = int.Parse(TestContext.Properties["GoodArea"].ToString());
            _goodRadius = double.Parse(TestContext.Properties["GoodRadius"].ToString());
        }


    }
}
