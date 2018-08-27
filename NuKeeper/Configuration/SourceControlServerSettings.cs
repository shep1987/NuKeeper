namespace NuKeeper.Configuration
{
    public class SourceControlServerSettings
    {
        public ServerScope Scope { get; set; }
        public string OrganisationName { get; set; }
        public RepositorySettings Repository { get; set; }
        public string[] Labels { get; set; }
    }
}
