using System;

using System.Collections;

namespace MDD4All.EAFacade.DataModels.Contracts
{
    public interface _Properties : IEnumerable
    {

        int Count
        {
            get;
        }

        /// 
        /// <param name="index"></param>
        Property Item(Object index);

        ObjectType ObjectType
        {
            get;
        }
    }
}