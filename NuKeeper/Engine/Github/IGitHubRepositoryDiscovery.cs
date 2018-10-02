using System.Collections.Generic;
using System.Threading.Tasks;
using NuKeeper.Configuration;
using NuKeeper.GitHub;

namespace NuKeeper.Engine.Github
{
    public interface IGitHubRepositoryDiscovery
    {
        Task<IEnumerable<RepositorySettings>> GetRepositories(IGitHub github, SourceControlServerSettings settings);
    }
}
