using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface IDualConnectorEnd  {

		Int32 Aggregation{
			get;
			set;
		}

		String Alias{
			get;
			set;
		}

		Boolean AllowDuplicates{
			get;
			set;
		}

		String Cardinality{
			get;
			set;
		}

		String Constraint{
			get;
			set;
		}

		String Containment{
			get;
			set;
		}

		Boolean Derived{
			get;
			set;
		}

		Boolean DerivedUnion{
			get;
			set;
		}

		String End{
			get;
		}

		String GetLastError();

		String IsChangeable{
			get;
			set;
		}

		Boolean IsNavigable{
			get;
			set;
		}

		String Navigable{
			get;
			set;
		}

		ObjectType ObjectType{
			get;
		}

		Int32 Ordering{
			get;
			set;
		}

		Boolean OwnedByClassifier{
			get;
			set;
		}

		String Qualifier{
			get;
			set;
		}

		String Role{
			get;
			set;
		}

		String RoleNote{
			get;
			set;
		}

		String RoleType{
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

		Collection TaggedValues{
			get;
		}

		Boolean Update();

		String Visibility{
			get;
			set;
		}
	}//end IDualConnectorEnd

}//end namespace Contracts