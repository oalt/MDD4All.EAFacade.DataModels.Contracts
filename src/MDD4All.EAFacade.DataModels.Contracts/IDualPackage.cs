using System;

namespace MDD4All.EAFacade.DataModels.Contracts
{
	public interface IDualPackage
	{

		String Alias
		{
			get;
			set;
		}

		/// 
		/// <param name="aGroupName"></param>
		Boolean ApplyGroupLock(String aGroupName);

		/// 
		/// <param name="aGroupName"></param>
		/// <param name="IncludeElements"></param>
		/// <param name="IncludeDiagrams"></param>
		/// <param name="IncludeSubPackages"></param>
		Boolean ApplyGroupLockRecursive(String aGroupName, Boolean IncludeElements, Boolean IncludeDiagrams, Boolean IncludeSubPackages);

		Boolean ApplyUserLock();

		/// 
		/// <param name="IncludeElements"></param>
		/// <param name="IncludeDiagrams"></param>
		/// <param name="IncludeSubPackages"></param>
		Boolean ApplyUserLockRecursive(Boolean IncludeElements, Boolean IncludeDiagrams, Boolean IncludeSubPackages);

		Int32 BatchLoad
		{
			get;
			set;
		}

		Int32 BatchSave
		{
			get;
			set;
		}

		Package Clone();

		String CodePath
		{
			get;
			set;
		}

		GenericCollection<Connector> Connectors
		{
			get;
		}

		DateTime Created
		{
			get;
			set;
		}

		GenericCollection<Diagram> Diagrams
		{
			get;
		}

		Element Element
		{
			get;
		}

		GenericCollection<Element> Elements
		{
			get;
		}

		/// 
		/// <param name="DottedID"></param>
		Object FindObject(String DottedID);

		String Flags
		{
			get;
			set;
		}

		void GenerateSourceCode();

		/// 
		/// <param name="CodeIDs"></param>
		//CodeObject GetClassCodeObjects(String CodeIDs);

		/// 
		/// <param name="CodeID"></param>
		//CodeObject GetCodeObject(String CodeID);

		/// 
		/// <param name="GUID"></param>
		/// <param name="ProjectType"></param>
		void GetCodeProject(ref String GUID, ref String ProjectType);

		String GetLastError();

		Boolean IsControlled
		{
			get;
			set;
		}

		Boolean IsModel
		{
			get;
		}

		Boolean IsNamespace
		{
			get;
			set;
		}

		Boolean IsProtected
		{
			get;
			set;
		}

		Boolean IsVersionControlled
		{
			get;
		}

		DateTime LastLoadDate
		{
			get;
		}

		DateTime LastSaveDate
		{
			get;
		}

		Boolean LogXML
		{
			get;
			set;
		}

		DateTime Modified
		{
			get;
			set;
		}

		String Name
		{
			get;
			set;
		}

		String Notes
		{
			get;
			set;
		}

		ObjectType ObjectType
		{
			get;
		}

		String Owner
		{
			get;
			set;
		}

		String PackageGUID
		{
			get;
			set;
		}

		Int32 PackageID
		{
			get;
		}

		Collection Packages
		{
			get;
		}

		Int32 ParentID
		{
			get;
			set;
		}

		Boolean ReleaseUserLock();

		/// 
		/// <param name="IncludeElements"></param>
		/// <param name="IncludeDiagrams"></param>
		/// <param name="IncludeSubPackages"></param>
		Boolean ReleaseUserLockRecursive(Boolean IncludeElements, Boolean IncludeDiagrams, Boolean IncludeSubPackages);

		/// 
		/// <param name="GUID"></param>
		/// <param name="ProjectType"></param>
		void SetCodeProject(String GUID, String ProjectType);

		/// 
		/// <param name="ReadOnly"></param>
		/// <param name="IncludeSubPkgs"></param>
		void SetReadOnly(Boolean ReadOnly, Boolean IncludeSubPkgs);

		/// 
		/// <param name="CodeIDs"></param>
		//CodeObject ShallowGetClassCodeObjects(String CodeIDs);

		String StereotypeEx
		{
			get;
			set;
		}

		Int32 TreePos
		{
			get;
			set;
		}

		String UMLVersion
		{
			get;
			set;
		}

		Boolean Update();

		Boolean UseDTD
		{
			get;
			set;
		}

		String Version
		{
			get;
			set;
		}

		/// 
		/// <param name="ConfigGuid"></param>
		/// <param name="XMLFile"></param>
		/// <param name="Comment"></param>
		/// <param name="KeepCheckedOut"></param>
		void VersionControlAdd(String ConfigGuid, String XMLFile, String Comment, Boolean KeepCheckedOut);

		/// 
		/// <param name="Comment"></param>
		void VersionControlCheckin(String Comment);

		/// 
		/// <param name="Comment"></param>
		/// <param name="PreserveCrossPkgRefs"></param>
		void VersionControlCheckinEx(String Comment, Boolean PreserveCrossPkgRefs);

		/// 
		/// <param name="Comment"></param>
		void VersionControlCheckout(String Comment);

		/// 
		/// <param name="ForceImport"></param>
		void VersionControlGetLatest(Boolean ForceImport);

		Int32 VersionControlGetStatus();

		/// 
		/// <param name="Comment"></param>
		void VersionControlPutLatest(String Comment);

		void VersionControlRemove();

		/// 
		/// <param name="ClearSettings"></param>
		void VersionControlResynchPkgStatus(Boolean ClearSettings);

		String XMLPath
		{
			get;
			set;
		}
	}//end IDualPackage

}//end namespace Contracts