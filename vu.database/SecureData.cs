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
}