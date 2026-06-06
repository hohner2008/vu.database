using System.Data;
using System.Reflection;

namespace vu.database;

using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.DependencyInjection;

public class SecureData
{   
    private IDataProtector? _protector;
    
    public SecureData(IDataProtectionProvider? provider)
    {
        _protector = provider?.CreateProtector(GetType().FullName);
    }

    public static bool CheckIfSecure(object? model)
    {
        var fullName = model?.GetType().FullName;
        var name = model?.GetType().Name;
        var domain = fullName.Replace(name, "");
        if (domain != "vu.database.model.") throw new DataException("Not in model domain: " + fullName);
        var a = model?.GetType().GetCustomAttribute<SecureAttribute>();
        if (a == null) return false;
        return true;
    }
}