using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface IDualParameter  {

		String Alias{
			get;
			set;
		}

		String ClassifierID{
			get;
			set;
		}

		String Default{
			get;
			set;
		}

		String GetLastError();

		Boolean IsConst{
			get;
			set;
		}

		String Kind{
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

		Int32 OperationID{
			get;
		}

		String ParameterGUID{
			get;
			set;
		}

		Int32 Position{
			get;
			set;
		}

		String Stereotype{
			get;
			set;
		}

		String StereotypeEx{
			get;
			set;
		}

		String Style{
			get;
			set;
		}

		String StyleEx{
			get;
			set;
		}

		Collection TaggedValues{
			get;
		}

		String Type{
			get;
			set;
		}

		Boolean Update();
	}//end IDualParameter

}//end namespace Contracts