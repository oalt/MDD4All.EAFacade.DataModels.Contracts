namespace MDD4All.EAFacade.DataModels.Contracts.Extensions
{
    public class RepositoryObjectDescriptor
    {
        public string ConnectionString { get; set; }

        public string GUID { get; set; } = string.Empty;

        public string Name { get; set; } = "<Nothing selected>";

        public ObjectType ObjectType { get; set; } = ObjectType.otRepository;
    }
}
