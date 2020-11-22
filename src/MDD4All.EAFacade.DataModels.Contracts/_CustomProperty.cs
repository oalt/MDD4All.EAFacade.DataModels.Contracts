using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface _CustomProperty  {

		String Name{
			get;
		}

		ObjectType ObjectType{
			get;
		}

		String Value{
			get;
			set;
		}
	}//end _CustomProperty

}//end namespace Contracts