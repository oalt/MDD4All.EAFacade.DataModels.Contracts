using System;

namespace MDD4All.EnterpriseArchitect.DataModels.Contracts
{
	public interface _Swimlane
	{

		Int32 BackColor
		{
			get;
			set;
		}

		String ClassifierGuid
		{
			get;
			set;
		}

		ObjectType ObjectType
		{
			get;
		}

		String Title
		{
			get;
			set;
		}

		Int32 Width
		{
			get;
			set;
		}
	}//end _Swimlane

}//end namespace Contracts