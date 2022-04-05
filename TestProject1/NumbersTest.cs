using System;
using CodeCoverage;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var numbers = new Numbers();
            numbers.Add(1);
            numbers.Add(2);
            Assert.AreEqual(3, numbers.GetSum());
        }

        [Test]
        public void Test2()
        {
            var numbers = new Numbers();
            numbers.Add(1);
            numbers.Add(2);
            Assert.AreEqual(1.5, numbers.GetMean());
        }

        [Test]
        public void Test3()
        {
            var numbers = new Numbers();
            numbers.Add(1);
            numbers.Add(2);
            Assert.AreEqual(1.5, numbers.GetMean());
        }

        [Test]
        public void Test4()
        {
            var numbers = new Numbers();
            Assert.AreEqual(
                null, 
                numbers.GetMedian());
        }

        [Test]
        public void Test5()
        {
            var numbers = new Numbers();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            Assert.AreEqual(
                2,
                numbers.GetMedian());
        }

        [Test]
        public void Test6()
        {
            var numbers = new Numbers();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            Assert.AreEqual(
                2.5,
                numbers.GetMedian());
        }

        [Test]
        public void Test7()
        {
            var numbers = new Numbers();
            Assert.Throws<ArgumentOutOfRangeException>(
                () => numbers.GetMedian2());
        }
    }
}