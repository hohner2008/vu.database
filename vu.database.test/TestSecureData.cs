using Xunit;
using vu.database;
using vu.database.model;

namespace vu.database.test;

public class TestSecureData
{
    [Fact]
    void TestCheckIfSecure()
    {
        var user = new User { Name = "test", Password = "test" };
        SecureData.CheckIfSecure(user);
    }
}