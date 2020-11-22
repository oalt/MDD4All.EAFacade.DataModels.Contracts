using System;
using System.Collections.Generic;

namespace MDD4All.EAFacade.DataModels.Contracts
{
    public class GenericCollection<T> : List<T>, Collection
    {
        public ObjectType ObjectType
        {
            get
            {
                return ObjectType.otCollection;
            }
        }

        short IDualCollection.Count {

            get
            {
                short result = 0;

                result = (short) Count;

                return result;
            }
            
        }

        public object AddNew(string Name, string Type)
        {
            throw new NotImplementedException();
        }

        public void Delete(short index)
        {
            RemoveAt(index);
        }

        public void DeleteAt(short index, bool Refresh)
        {
            RemoveAt(index);
        }

        public object GetAt(short index)
        {
            object result = null;

            result = this[index];

            return result;
        }

        public object GetByName(string Name)
        {
            throw new NotImplementedException();
        }

        public string GetLastError()
        {
            string result = "";

            return result;
        }

        public void Refresh()
        {
            ;
        }
    }
}
