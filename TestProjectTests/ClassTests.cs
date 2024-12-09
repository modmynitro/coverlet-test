using NUnit.Framework;
using TestProject;

namespace TestProjectTests;

public sealed class ClassTests
{
    [Test]
    public void TestMethod()
    {
       new Class().Method();
    }
}