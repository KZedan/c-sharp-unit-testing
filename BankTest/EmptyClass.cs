using System.Collections.Generic;
using NUnit.Framework;

namespace StackTests
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void Creation()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.AreEqual(0, s.Size);
        }
    }
}
