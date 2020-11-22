using System;

namespace MDD4All.EnterpriseArchitect.DataModels.Contracts {
	public interface _SwimlaneDef  {

		Boolean bold{
			get;
			set;
		}

		Int32 FontColor{
			get;
			set;
		}

		Boolean HideClassifier{
			get;
			set;
		}

		Boolean HideNames{
			get;
			set;
		}

		Int32 LineColor{
			get;
			set;
		}

		Int32 LineWidth{
			get;
			set;
		}

		Boolean Locked{
			get;
			set;
		}

		ObjectType ObjectType{
			get;
		}

		SwimlaneOrientationType Orientation{
			get;
			set;
		}

		Boolean ShowInTitleBar{
			get;
			set;
		}

		Swimlanes Swimlanes{
			get;
		}
	}//end _SwimlaneDef

}//end namespace Contracts