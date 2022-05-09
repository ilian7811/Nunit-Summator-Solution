using NUnit.Framework;
using System;

namespace Summator.Tests
{
    public class SummatorTest

    {
       [Test]
       public void Test_Sum_TwoPositive_numbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });
            Assert.That(actual == 12);
        }

        [Test]
        public void Test_Sum_Multiple_Positive_numbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7, 8, 9, 10 });
            Assert.That(actual == 39);
        }


        [Test]
        public void Test_Sum_OnePositive_numbers()
        {
            long actual = Summator.Sum(new int[] { 6 });
            Assert.That(actual == 6);
        }

        [Test]
        public void Test_Two_Negative_numbers()
        {
            long average = Summator.Average(new int[] { 5, 10, 15 });
            if(average == 10)
            {
                Console.WriteLine("TEST PASS");
            }
            else
            {
                Console.WriteLine("TEST FAIL");
            }
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] {  });
            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_Big_Values()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });
            Assert.AreEqual(6000000000, actual);
        }

        [Test]
        public void Test_Average_TwoPositive_numbers()
        {
            long actual = Summator.Average(new int[] { 5, 7 });
            Assert.That(actual == 6);
        }

    }
}