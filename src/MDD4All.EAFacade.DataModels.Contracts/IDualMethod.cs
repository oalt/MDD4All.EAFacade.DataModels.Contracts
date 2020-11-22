using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface IDualMethod  {

		Boolean Abstract{
			get;
			set;
		}

		String Alias{
			get;
			set;
		}

		String Behavior{
			get;
			set;
		}

		String Behaviour{
			get;
			set;
		}

		String ClassifierID{
			get;
			set;
		}

		String Code{
			get;
			set;
		}

		String Concurrency{
			get;
			set;
		}

		String FQStereotype{
			get;
		}

		String GetLastError();

		Boolean IsConst{
			get;
			set;
		}

		Boolean IsLeaf{
			get;
			set;
		}

		Boolean IsPure{
			get;
			set;
		}

		Boolean IsQuery{
			get;
			set;
		}

		Boolean IsRoot{
			get;
			set;
		}

		Boolean IsStatic{
			get;
			set;
		}

		Boolean IsSynchronized{
			get;
			set;
		}

		String MethodGUID{
			get;
			set;
		}

		Int32 MethodID{
			get;
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

		Collection Parameters{
			get;
		}

		Int32 ParentID{
			get;
		}

		Int32 Pos{
			get;
			set;
		}

		Collection PostConditions{
			get;
		}

		Collection PreConditions{
			get;
		}

		Boolean ReturnIsArray{
			get;
			set;
		}

		String ReturnType{
			get;
			set;
		}

		String StateFlags{
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

		String Throws{
			get;
			set;
		}

		Boolean Update();

		String Visibility{
			get;
			set;
		}
	}//end IDualMethod

}//end namespace Contracts