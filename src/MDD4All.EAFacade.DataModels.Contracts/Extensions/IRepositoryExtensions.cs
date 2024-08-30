using System.Collections.Generic;

namespace MDD4All.EAFacade.DataModels.Contracts.Extensions
{
    public interface IRepositoryExtensions
    {
        List<Package> AllPackages { get; }

        List<Element> AllElements { get; }

        List<Connector> AllConnectors { get; }
    }
}
