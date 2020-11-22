namespace MDD4All.EnterpriseArchitect.DataModels.Contracts
{
    public interface _Property
    {

        string Name
        {
            get;
        }

        ObjectType ObjectType
        {
            get;
        }

        PropType Type
        {
            get;
        }

        string Validation
        {
            get;
        }

        object Value
        {
            get;
            set;
        }
    }
}