using Microsoft.EntityFrameworkCore.Diagnostics;

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
        string fullName = model?.GetType().FullName;
        return false;
    }
}