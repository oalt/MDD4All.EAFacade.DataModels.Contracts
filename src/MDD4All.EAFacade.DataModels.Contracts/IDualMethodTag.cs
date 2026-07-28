using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface IDualMethodTag  {

		String FQName{
			get;
		}

		///
		/// <param name="PropName"></param>
		String GetAttribute(String PropName);

		String GetLastError();

		Boolean HasAttributes();

		Int32 MethodID{
			get;
			set;
		}

		String Name{
			get;
			set;
		}

		String Notes{
			get;
			set;
		}

		ObjectType ObjectType{
			get;
		}

		///
		/// <param name="PropName"></param>
		/// <param name="PropValue"></param>
		Boolean SetAttribute(String PropName, String PropValue);

		String TagGUID{
			get;
			set;
		}

		Int32 TagID{
			get;
		}

		Boolean Update();

		String Value{
			get;
			set;
		}
	}//end IDualMethodTag

}//end namespace Contracts
