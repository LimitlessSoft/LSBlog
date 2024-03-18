using LSB.Contracts;
using LSCore.Framework;

namespace LSB.Api;

public class Startup : LSCoreBaseApiStartup
{
    public Startup()
        : base(Constants.ProjectName,
            addAuthentication: false)
    {
        
    }
}