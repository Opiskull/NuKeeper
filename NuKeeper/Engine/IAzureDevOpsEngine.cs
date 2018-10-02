using System.Threading.Tasks;
using NuKeeper.Configuration;

namespace NuKeeper.Engine
{
    public interface IAzureDevOpsEngine
    {
        Task<int> Run(SettingsContainer settings);
    }
}
