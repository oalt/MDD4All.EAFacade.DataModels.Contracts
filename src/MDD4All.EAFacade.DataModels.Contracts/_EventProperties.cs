using System.Collections;

namespace MDD4All.EAFacade.DataModels.Contracts
{
    public interface _EventProperties
    {
        new IEnumerator GetEnumerator();

        EventProperty Get(object index);


        int Count
        {
            get;
        }

        ObjectType ObjectType
        {
            get;
        }
    }
}
