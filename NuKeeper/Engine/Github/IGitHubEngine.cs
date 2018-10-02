using System.Threading.Tasks;
using NuKeeper.Configuration;

namespace NuKeeper.Engine.Github
{
    public interface IGitHubEngine
    {
        Task<int> Run(SettingsContainer settings);
    }
}
