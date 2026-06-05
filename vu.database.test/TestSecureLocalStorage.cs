using vu.database.model;
using Xunit;

namespace vu.database.test;

public class TestSecureLocalStorage
{
    [Fact]
    public async Task TestCreateSecureLocalStorage()
    {
        var context = SecureLocalStorageContext.Instance;
        Assert.NotNull(context);
        context.Database.EnsureCreated();
        context.Users.Add(
            new User { Name = "Hello World", Password = "I wrote an app using EF Core!" });
        await context.SaveChangesAsync();
    }
}