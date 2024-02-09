using desktop_app;

namespace unit_test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(3, App.Sum(1, 2));
    }
}