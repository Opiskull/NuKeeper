using LibGit2Sharp;
using NuKeeper.Configuration;
using System.Threading.Tasks;

namespace NuKeeper.Engine.Github
{
    public interface IGitHubRepositoryEngine
    {
        Task<int> Run(RepositorySettings repository,
            UsernamePasswordCredentials gitCreds, Identity userIdentity,
            SettingsContainer settings);
    }
}
