using NUnit.Framework;
using Slice;
using System.Linq;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
          
        }


        [Test]
        public void TestSlice()
        {
            string result = "<12345>".Slice("<", ">");
            Assert.AreEqual("12345", result);
        }
        [Test]
        public void TestSliceCoolection()
        {
           var result =  "1<1>".SliceInfo("<", ">");
            if (result.FirstOrDefault() != "1") throw new System.Exception();
        }
               
    }
}