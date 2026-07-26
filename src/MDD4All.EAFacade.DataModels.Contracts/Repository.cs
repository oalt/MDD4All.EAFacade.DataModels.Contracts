using MDD4All.EAFacade.DataModels.Contracts.Extensions;
using EAAPI = EA;

namespace MDD4All.EAFacade.DataModels.Contracts
{
	public interface Repository : IDualRepository, IRepositoryExtensions
	{
        EAAPI.Repository? ApiRepository { get; set; }

    }//end Repository

}//end namespace Contracts