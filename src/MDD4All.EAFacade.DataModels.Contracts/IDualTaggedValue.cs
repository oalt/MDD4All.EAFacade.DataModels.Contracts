namespace MDD4All.EAFacade.DataModels.Contracts
{
    public interface IDualTaggedValue
    {

        int ElementID
        {
            get;
            set;
        }

        string FQName
        {
            get;
        }


        string Name
        {
            get;
            set;
        }

        string Notes
        {
            get;
            set;
        }

        ObjectType ObjectType
        {
            get;
        }

        int ParentID
        {
            get;
        }

        string PropertyGUID
        {
            get;
            set;
        }

        int PropertyID
        {
            get;
        }


        string Value
        {
            get;
            set;
        }

        string GetAttribute(string PropName);

        string GetLastError();

        bool HasAttributes();

        bool SetAttribute(string PropName, string PropValue);

        bool Update();
    }
}