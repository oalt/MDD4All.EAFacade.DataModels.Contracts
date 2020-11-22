using System;
using System.Collections;

namespace MDD4All.EAFacade.DataModels.Contracts
{
	public interface _Swimlanes : IEnumerable
	{

		/// 
		/// <param name="Title"></param>
		/// <param name="Width"></param>
		Swimlane Add(string Title, int Width);

        int Count
		{
			get;
		}

		/// 
		/// <param name="index"></param>
		void Delete(Object index);

		void DeleteAll();

		//IEnumerator GetEnumerator();

		/// 
		/// <param name="index"></param>
		/// <param name="Title"></param>
		/// <param name="Width"></param>
		Swimlane Insert(Int32 index, String Title, Int32 Width);

		/// 
		/// <param name="index"></param>
		Swimlane Items(Object index);

		ObjectType ObjectType
		{
			get;
		}
	}//end _Swimlanes

}//end namespace Contracts