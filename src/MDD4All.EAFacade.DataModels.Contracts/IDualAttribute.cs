using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface IDualAttribute  {

		String Alias{
			get;
			set;
		}

		Boolean AllowDuplicates{
			get;
			set;
		}

		String AttributeGUID{
			get;
			set;
		}

		Int32 AttributeID{
			get;
		}

		Int32 ClassifierID{
			get;
			set;
		}

		Collection Constraints{
			get;
		}

		String Container{
			get;
			set;
		}

		String Containment{
			get;
			set;
		}

		String Default{
			get;
			set;
		}

		String FQStereotype{
			get;
		}

		String GetLastError();

		Boolean IsCollection{
			get;
			set;
		}

		Boolean IsConst{
			get;
			set;
		}

		Boolean IsDerived{
			get;
			set;
		}

		Boolean IsID{
			get;
			set;
		}

		Boolean IsOrdered{
			get;
			set;
		}

		Boolean IsStatic{
			get;
			set;
		}

		String Length{
			get;
			set;
		}

		String LowerBound{
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

		Int32 ParentID{
			get;
		}

		Int32 Pos{
			get;
			set;
		}

		String Precision{
			get;
			set;
		}

		String RedefinedProperty{
			get;
			set;
		}

		String Scale{
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

		String SubsettedProperty{
			get;
			set;
		}

		Collection TaggedValues{
			get;
		}

		Collection TaggedValuesEx{
			get;
		}

		String Type{
			get;
			set;
		}

		Boolean Update();

		String UpperBound{
			get;
			set;
		}

		String Visibility{
			get;
			set;
		}
	}//end IDualAttribute

}//end namespace Contracts