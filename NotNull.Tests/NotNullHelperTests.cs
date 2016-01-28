using NUnit.Framework;
using NotNull;
using System;

namespace NotNull.Tests
{
    [TestFixture]
    public class IfNotNullTests
    {
        [Test]
        public void IfNotNullShouldReturnNullForNull()
        {
            string testObject = null;
            var testOutput = testObject.IfNotNull(s => s + "hello");

            Assert.IsNull(testOutput);
        }

        [Test]
        public void IfNotNullShouldReturnValueWhenNotNull()
        {
            string testObject = "He";
            var testOutput = testObject.IfNotNull(s => s + "llo");

            Assert.IsNotNull(testOutput);
            Assert.AreEqual("Hello", testOutput);
        }

        [Test]
        public void IfNotNullThenDefaultShouldReturnDefaultForNull()
        {
            int? testObject = null;
            var testOutput = testObject.IfNotNullElseDefault<int?, int>(i => i.Value + 5);

            Assert.IsNotNull(testOutput);
            Assert.AreEqual(default(int), testOutput);
        }

        [Test]
        public void IfNotNullThenDefaultShouldReturnValueWhenNotNull()
        {
            int? testObject = 5;
            var testOutput = testObject.IfNotNullElseDefault(i => i.Value + 5);

            Assert.IsNotNull(testOutput);
            Assert.AreEqual(10, testOutput);
        }

        [Test]
        public void IfNotNullShouldDoNothingWhenNull()
        {
            string testObject = null;
            bool actionRun = false;
            testObject.IfNotNull(t =>
                {
                    actionRun = true;
                });

            Assert.IsFalse(actionRun);
        }

        [Test]
        public void IfNotNullShouldDoSomethingWhenNotNull()
        {
            string testObject = "Hello";
            bool actionRun = false;
            testObject.IfNotNull(t =>
                {
                    actionRun = true;
                });

            Assert.IsTrue(actionRun);
        }

        [Test]
        public void IfNotNullOrDefaultShouldReturnDefaultWhenNull()
        {
            string testObject = null;
            var testOutput = testObject.IfNotNullOrDefault(s => s + "Hello");

            Assert.IsNull(testOutput);
        }

        [Test]
        public void IfNotNullOrDefaultShouldReturnDefaultWhenDefault()
        {
            int testObject = 0;
            var testOutput = testObject.IfNotNullOrDefault(i => i + 1);

            Assert.AreEqual(0, testOutput);
        }

        [Test]
        public void IfNotNullOrDefaultShouldDoNothingWhenNull()
        {
            string testObject = null;
            bool actionRun = false;
            testObject.IfNotNullOrDefault(t =>
                {
                    actionRun = true;
                });

            Assert.IsFalse(actionRun);
        }

        [Test]
        public void IfNotNullOrDefaultShouldDoNothingWhenDefault()
        {
            int testObject = 0;
            bool actionRun = false;
            testObject.IfNotNullOrDefault(t =>
                {
                    actionRun = true;
                });

            Assert.IsFalse(actionRun);
        }

        [Test]
        public void IfNotNullOrDefaultShouldDoSomethingWhenNotNullOrDefault()
        {
            int testObject = 1;
            bool actionRun = false;
            testObject.IfNotNullOrDefault(t =>
                {
                    actionRun = true;
                });

            Assert.IsTrue(actionRun);
        }
    }
}

