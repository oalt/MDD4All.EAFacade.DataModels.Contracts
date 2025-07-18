namespace MDD4All.EAFacade.DataModels.Contracts
{
    public interface _EventProperty
    {

        object Value
        {
            get;
        }

        string Name
        {
            get;
        }

        string Description
        {
            get;
        }

        ObjectType ObjectType
        {
            get;
        }
    }
}
