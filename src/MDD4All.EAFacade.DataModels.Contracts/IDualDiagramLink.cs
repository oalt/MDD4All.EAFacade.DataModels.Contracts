using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface IDualDiagramLink  {

		Int32 ConnectorID{
			get;
			set;
		}

		Int32 DiagramID{
			get;
			set;
		}

		String Geometry{
			get;
			set;
		}

		String GetLastError();

		Boolean HiddenLabels{
			get;
			set;
		}

		Int32 InstanceID{
			get;
			set;
		}

		Boolean IsHidden{
			get;
			set;
		}

		Int32 LineColor{
			get;
			set;
		}

		LinkLineStyle LineStyle{
			get;
			set;
		}

		Int32 LineWidth{
			get;
			set;
		}

		ObjectType ObjectType{
			get;
		}

		String Path{
			get;
			set;
		}

		String SourceInstanceUID{
			get;
		}

		String Style{
			get;
			set;
		}

		Int32 SuppressSegment{
			get;
			set;
		}

		String TargetInstanceUID{
			get;
		}

		Boolean Update();
	}//end IDualDiagramLink

}//end namespace Contracts