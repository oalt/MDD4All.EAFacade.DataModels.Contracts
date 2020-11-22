using System;

namespace MDD4All.EnterpriseArchitect.DataModels.Contracts {
	public interface IDualConnector  {

		String Alias{
			get;
			set;
		}

		Element AssociationClass{
			get;
		}

		ConnectorEnd ClientEnd{
			get;
		}

		Int32 ClientID{
			get;
			set;
		}

		Int32 Color{
			get;
			set;
		}

		String ConnectorGUID{
			get;
		}

		Int32 ConnectorID{
			get;
		}

		Collection Constraints{
			get;
		}

		Collection ConveyedItems{
			get;
		}

		Collection CustomProperties{
			get;
		}

		Int32 DiagramID{
			get;
			set;
		}

		String Direction{
			get;
			set;
		}

		Int32 EndPointX{
			get;
			set;
		}

		Int32 EndPointY{
			get;
			set;
		}

		String EventFlags{
			get;
			set;
		}

		String ForeignKeyInformation{
			get;
		}

		String FQStereotype{
			get;
		}

		String GetLastError();

		Boolean IsConnectorValid();

		Boolean IsLeaf{
			get;
			set;
		}

		Boolean IsRoot{
			get;
			set;
		}

		Boolean IsSpec{
			get;
			set;
		}

		String MessageArguments{
			get;
		}

		String MetaType{
			get;
			set;
		}

		String MiscData{
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

		Properties Properties{
			get;
		}

		String ReturnValueAlias{
			get;
		}

		Int32 RouteStyle{
			get;
			set;
		}

		Int32 SequenceNo{
			get;
			set;
		}

		Int32 StartPointX{
			get;
			set;
		}

		Int32 StartPointY{
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

		String StyleEx{
			get;
			set;
		}

		String Subtype{
			get;
			set;
		}

		ConnectorEnd SupplierEnd{
			get;
		}

		Int32 SupplierID{
			get;
			set;
		}

		Collection TaggedValues{
			get;
		}

		Collection TemplateBindings{
			get;
		}

		String TransitionAction{
			get;
			set;
		}

		String TransitionEvent{
			get;
			set;
		}

		String TransitionGuard{
			get;
			set;
		}

		String Type{
			get;
			set;
		}

		Boolean Update();

		String VirtualInheritance{
			get;
			set;
		}

		Int32 Width{
			get;
			set;
		}
	}//end IDualConnector

}//end namespace Contracts