using Microsoft.EntityFrameworkCore;

namespace vu.database;

public class SecureLocalStorageContext:DbContext
{
    public string DbPath { get; }
    private SecureLocalStorageContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "local_secure.db");
    }
    
    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    public static DbContext Instance { get; } = new SecureLocalStorageContext();
    
    public void RemoveDatabase()
    {
        // Returns the logical catalog/database name
        File.Delete(DbPath);
    }

    public void MakeCopyDatabase(string destination)
    {
        File.Copy(DbPath, destination, true);
    }
}