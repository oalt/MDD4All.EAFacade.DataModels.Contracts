using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface IDualDiagram  {

		/// 
		/// <param name="aGroupName"></param>
		Boolean ApplyGroupLock(String aGroupName);

		Boolean ApplyUserLock();

        string Author
        {
			get;
			set;
		}

		DateTime CreatedDate{
			get;
			set;
		}

        int cx
        {
			get;
			set;
		}

		Int32 cy{
			get;
			set;
		}

		String DiagramGUID{
			get;
			set;
		}

		Int32 DiagramID{
			get;
		}

		GenericCollection<DiagramLink> DiagramLinks
		{
			get;
		}

		GenericCollection<DiagramObject> DiagramObjects
		{
			get;
		}

		String ExtendedStyle{
			get;
			set;
		}

		String FilterElements{
			get;
			set;
		}

		/// 
		/// <param name="NewVal"></param>
		Boolean FindElementInDiagram(Int32 NewVal);

		/// 
		/// <param name="nID"></param>
		/// <param name="sDUID"></param>
		DiagramObject GetDiagramObjectByID(Int32 nID, String sDUID);

		String GetLastError();

		Boolean HighlightImports{
			get;
			set;
		}

		Boolean IsLocked{
			get;
			set;
		}

		String MetaType{
			get;
			set;
		}

		DateTime ModifiedDate{
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

		String Orientation{
			get;
			set;
		}

		Int32 PackageID{
			get;
			set;
		}

		Int32 PageHeight{
			get;
		}

		Int32 PageWidth{
			get;
		}

		Int32 ParentID{
			get;
			set;
		}

		/// 
		/// <param name="Style"></param>
		String ReadStyle(String Style);

		Boolean ReleaseUserLock();

		void ReorderMessages();

		/// 
		/// <param name="sFilename"></param>
		Boolean SaveAsPDF(String sFilename);

		/// 
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="sizeX"></param>
		/// <param name="sizeY"></param>
		/// <param name="FileName"></param>
		/// <param name="Flags"></param>
		Boolean SaveImagePage(Int32 x, Int32 y, Int32 sizeX, Int32 sizeY, String FileName, Int32 Flags);

		Int32 Scale{
			get;
			set;
		}

		Connector SelectedConnector{
			get;
			set;
		}

		Collection SelectedObjects{
			get;
		}

		/// 
		/// <param name="ShowAsList"></param>
		/// <param name="Persist"></param>
		void ShowAsElementList(Boolean ShowAsList, Boolean Persist);

		Int32 ShowDetails{
			get;
			set;
		}

		Boolean ShowPackageContents{
			get;
			set;
		}

		Boolean ShowPrivate{
			get;
			set;
		}

		Boolean ShowProtected{
			get;
			set;
		}

		Boolean ShowPublic{
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

		SwimlaneDef SwimlaneDef{
			get;
		}

		String Swimlanes{
			get;
			set;
		}

		String Type{
			get;
		}

		Boolean Update();

		String Version{
			get;
			set;
		}

		/// 
		/// <param name="connId"></param>
		/// <param name="action"></param>
		/// <param name="x"></param>
		/// <param name="y"></param>
		Boolean VirtualizeConnector(Int32 connId, Int32 action, Int32 x, Int32 y);

		/// 
		/// <param name="connId"></param>
		Int32 VirtualizedEnd(Int32 connId);

		/// 
		/// <param name="Style"></param>
		/// <param name="Value"></param>
		void WriteStyle(String Style, String Value);
	}//end IDualDiagram

}//end namespace Contracts