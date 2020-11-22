using System;
using System.Collections;

namespace MDD4All.EAFacade.DataModels.Contracts
{
    public interface IDualCollection : IEnumerable
    {

        /// 
        /// <param name="Name"></param>
        /// <param name="Type"></param>
        object AddNew(string Name, string Type);

        short Count
        {
            get;
        }

        /// 
        /// <param name="index"></param>
        void Delete(short index);

        /// 
        /// <param name="index"></param>
        /// <param name="Refresh"></param>
        void DeleteAt(short index, Boolean Refresh);

        /// 
        /// <param name="index"></param>
        object GetAt(short index);

        /// 
        /// <param name="Name"></param>
        object GetByName(string Name);

        string GetLastError();

        ObjectType ObjectType
        {
            get;
        }

        void Refresh();
    }

}