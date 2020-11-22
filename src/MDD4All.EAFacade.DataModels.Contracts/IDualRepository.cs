using System;

namespace MDD4All.EAFacade.DataModels.Contracts
{

	public interface IDualRepository
	{

		/// 
		/// <param name="No"></param>
		/// <param name="No2"></param>
		/// <param name="pNo3"></param>
		Int32 __TempDebug(Int32 No, DateTime No2, ref Int32 pNo3);

		/// 
		/// <param name="DiagramID"></param>
		void ActivateDiagram(Int32 DiagramID);

		/// 
		/// <param name="Perspective"></param>
		/// <param name="Options"></param>
		Boolean ActivatePerspective(String Perspective, Int32 Options);

		/// 
		/// <param name="Name"></param>
		void ActivateTab(String Name);

		/// 
		/// <param name="ID"></param>
		Boolean ActivateTechnology(String ID);

		/// 
		/// <param name="Toolbox"></param>
		/// <param name="Options"></param>
		Boolean ActivateToolbox(String Toolbox, Int32 Options);

		/// 
		/// <param name="sXML"></param>
		Boolean AddDefinedSearches(String sXML);

		/// 
		/// <param name="Name"></param>
		/// <param name="Path"></param>
		/// <param name="Type"></param>
		Boolean AddDocumentationPath(Object Name, Object Path, Int32 Type);

		/// 
		/// <param name="Perspective"></param>
		/// <param name="Options"></param>
		Boolean AddPerspective(String Perspective, Int32 Options);

		/// 
		/// <param name="TabName"></param>
		/// <param name="ControlID"></param>
		Object AddTab(String TabName, String ControlID);

		/// 
		/// <param name="TabName"></param>
		/// <param name="ControlID"></param>
		Object AddWindow(String TabName, String ControlID);

		/// 
		/// <param name="ConnectorID"></param>
		void AdviseConnectorChange(Int32 ConnectorID);

		/// 
		/// <param name="ElementID"></param>
		void AdviseElementChange(Int32 ElementID);

		//App App{
		//	get;
		//}

		Collection Authors
		{
			get;
		}

		Boolean BatchAppend
		{
			get;
			set;
		}

		/// 
		/// <param name="Name"></param>
		/// <param name="Password"></param>
		Boolean ChangeLoginUser(String Name, String Password);

		/// 
		/// <param name="StateDateTime"></param>
		/// <param name="EndDateTime"></param>
		Boolean ClearAuditLogs(Object StateDateTime, Object EndDateTime);

		/// 
		/// <param name="flagSet"></param>
		/// <param name="objectID"></param>
		Int32 ClearObjectFlags(String flagSet, Int32 objectID);

		/// 
		/// <param name="Name"></param>
		void ClearOutput(String Name);

		Collection Clients
		{
			get;
		}

		void CloseAddins();

		/// 
		/// <param name="DiagramID"></param>
		void CloseDiagram(Int32 DiagramID);

		void CloseFile();

		String ConnectionString
		{
			get;
		}

		//DocumentGenerator CreateDocumentGenerator();

		/// 
		/// <param name="CreateType"></param>
		/// <param name="FilePath"></param>
		/// <param name="ParentWnd"></param>
		//Boolean CreateModel(CreateModelType CreateType, String FilePath, Int32 ParentWnd);

		//ModelWatcher CreateModelWatcher();

		/// 
		/// <param name="Name"></param>
		void CreateOutputTab(String Name);

		/// 
		/// <param name="ClassName"></param>
		/// <param name="MethodName"></param>
		/// <param name="Parameters"></param>
		String CustomCommand(String ClassName, String MethodName, String Parameters);

		Collection Datatypes
		{
			get;
		}

		/// 
		/// <param name="flagSet"></param>
		/// <param name="image"></param>
		Boolean DefineOverlay(String flagSet, String image);

		/// 
		/// <param name="Perspective"></param>
		/// <param name="Options"></param>
		Boolean DeletePerspective(String Perspective, Int32 Options);

		/// 
		/// <param name="ID"></param>
		Boolean DeleteTechnology(String ID);

		EAEditionTypes EAEdition
		{
			get;
		}

		EAEditionTypes EAEditionEx
		{
			get;
		}

		Boolean EnableCache
		{
			get;
			set;
		}

		Int32 EnableEventFlags
		{
			get;
			set;
		}

		Boolean EnableUIUpdates
		{
			get;
			set;
		}

		/// 
		/// <param name="Name"></param>
		void EnsureOutputVisible(String Name);

		/// 
		/// <param name="SQL"></param>
		void Execute(String SQL);

		/// 
		/// <param name="ScriptOptions"></param>
		/// <param name="PackageGUID"></param>
		void ExecutePackageBuildScript(Int32 ScriptOptions, String PackageGUID);

		void Exit();

		/// 
		/// <param name="Notes"></param>
		/// <param name="absPath"></param>
		/// <param name="imagePath"></param>
		/// <param name="applyMapOption"></param>
		String ExtractImagesFromNote(Object Notes, Object absPath, Object imagePath, Int32 applyMapOption);

		Boolean FlagUpdate
		{
			get;
			set;
		}

		/// 
		/// <param name="mtsFilename"></param>
		Boolean GenerateMDGTechnology(String mtsFilename);

		String GetActivePerspective();

		/// 
		/// <param name="GUID"></param>
		Attribute GetAttributeByGuid(String GUID);

		/// 
		/// <param name="AttributeID"></param>
		Attribute GetAttributeByID(Int32 AttributeID);

		/// 
		/// <param name="GUID"></param>
		Connector GetConnectorByGuid(String GUID);

		/// 
		/// <param name="ConnectorID"></param>
		Connector GetConnectorByID(Int32 ConnectorID);

		/// 
		/// <param name="Item"></param>
		ObjectType GetContextItem(ref Object Item);

		ObjectType GetContextItemType();

		Object GetContextObject();

		String GetCounts();

		Diagram GetCurrentDiagram();

		/// 
		/// <param name="GetGuid"></param>
		String GetCurrentLoginUser(Boolean GetGuid);

		/// 
		/// <param name="GUID"></param>
		Object GetDiagramByGuid(String GUID);

		/// 
		/// <param name="DiagramID"></param>
		Diagram GetDiagramByID(Int32 DiagramID);

		/// 
		/// <param name="dgmGUID"></param>
		//DiagramEditor GetDiagramEditor(String dgmGUID);

		/// 
		/// <param name="GUID"></param>
		Element GetElementByGuid(String GUID);

		/// 
		/// <param name="ElementID"></param>
		Element GetElementByID(Int32 ElementID);

		/// 
		/// <param name="QueryName"></param>
		/// <param name="SearchTerm"></param>
		Collection GetElementsByQuery(String QueryName, String SearchTerm);

		/// 
		/// <param name="IDList"></param>
		/// <param name="Unused"></param>
		Collection GetElementSet(String IDList, Int32 Unused);

		/// 
		/// <param name="Format"></param>
		/// <param name="Text"></param>
		String GetFieldFromFormat(String Format, String Text);

		/// 
		/// <param name="Format"></param>
		/// <param name="Text"></param>
		String GetFormatFromField(String Format, String Text);

		/// 
		/// <param name="GUID"></param>
		/// <param name="FlagInclude"></param>
		/// <param name="Separator"></param>
		/// <param name="FlagFormat"></param>
		String GetFormattedName(Object GUID, Int32 FlagInclude, Object Separator, Int32 FlagFormat);

		String GetGapAnalysisMatrix();

		String GetLastError();

		/// 
		/// <param name="sType"></param>
		/// <param name="sPath"></param>
		String GetLocalPath(String sType, String sPath);

		//IDualMailInterface GetMailInterface();

		/// 
		/// <param name="GUID"></param>
		//Method GetMethodByGuid(String GUID);

		/// 
		/// <param name="MethodID"></param>
		//Method GetMethodByID(Int32 MethodID);

		/// 
		/// <param name="GUID"></param>
		Package GetPackageByGuid(String GUID);

		/// 
		/// <param name="PackageID"></param>
		Package GetPackageByID(Int32 PackageID);

		//Project GetProjectInterface();

		/// 
		/// <param name="ListName"></param>
		//Reference GetReferenceList(String ListName);

		String GetRelationshipMatrix();

		/// 
		/// <param name="ID"></param>
		String GetTechnologyVersion(String ID);

		Collection GetTreeSelectedElements();

		/// 
		/// <param name="Item"></param>
		ObjectType GetTreeSelectedItem(ref Object Item);

		ObjectType GetTreeSelectedItemType();

		Object GetTreeSelectedObject();

		Package GetTreeSelectedPackage();

		/// 
		/// <param name="RootPackageID"></param>
		String GetTreeXML(Int32 RootPackageID);

		/// 
		/// <param name="GUID"></param>
		String GetTreeXMLByGUID(String GUID);

		/// 
		/// <param name="ElementID"></param>
		String GetTreeXMLForElement(Int32 ElementID);

		/// 
		/// <param name="Perspective"></param>
		String HasPerspective(String Perspective);

		void HideAddinWindow();

		/// 
		/// <param name="PackageGUID"></param>
		/// <param name="BuildScriptXML"></param>
		void ImportPackageBuildScripts(String PackageGUID, String BuildScriptXML);

		/// 
		/// <param name="pkgGUID"></param>
		/// <param name="protocol"></param>
		/// <param name="servername"></param>
		/// <param name="model"></param>
		/// <param name="storage"></param>
		/// <param name="rasGUID"></param>
		/// <param name="Version"></param>
		/// <param name="Password"></param>
		Boolean ImportRASAsset(String pkgGUID, String protocol, String servername, String model, String storage, String rasGUID, String Version, String Password);

		/// 
		/// <param name="Technology"></param>
		Boolean ImportTechnology(String Technology);

		String InstanceGUID
		{
			get;
		}

		/// 
		/// <param name="ConstructType"></param>
		Int32 InvokeConstructPicker(Object ConstructType);

		/// 
		/// <param name="FilterString"></param>
		/// <param name="DefaultFilterIndex"></param>
		/// <param name="Flags"></param>
		String InvokeFileDialog(Object FilterString, Int32 DefaultFilterIndex, Int32 Flags);

		Boolean IsSecurityEnabled
		{
			get;
		}

		Collection Issues
		{
			get;
		}

		/// 
		/// <param name="TabName"></param>
		Int32 IsTabOpen(String TabName);

		/// 
		/// <param name="ID"></param>
		Boolean IsTechnologyEnabled(String ID);

		/// 
		/// <param name="ID"></param>
		Boolean IsTechnologyLoaded(String ID);

		String LastUpdate
		{
			get;
		}

		Int32 LibraryVersion
		{
			get;
		}

		void LoadAddins();

		/// 
		/// <param name="Text"></param>
		String MarkupText(Object Text);

		Collection Models
		{
			get;
		}

		ObjectType ObjectType
		{
			get;
		}

		/// 
		/// <param name="DiagramID"></param>
		void OpenDiagram(Int32 DiagramID);

		/// 
		/// <param name="FilePath"></param>
		Boolean OpenFile(String FilePath);

		/// 
		/// <param name="FilePath"></param>
		/// <param name="Username"></param>
		/// <param name="Password"></param>
		Boolean OpenFile2(String FilePath, String Username, String Password);

		/// 
		/// <param name="Name"></param>
		Boolean OpenFileInEditor(Object Name);

		String ProjectGUID
		{
			get;
		}

		Collection ProjectRoles();

		Collection PropertyTypes
		{
			get;
		}

		/// 
		/// <param name="PackageID"></param>
		void RefreshModelView(Int32 PackageID);

		/// 
		/// <param name="FullReload"></param>
		void RefreshOpenDiagrams(Boolean FullReload);

		/// 
		/// <param name="DiagramID"></param>
		void ReloadDiagram(Int32 DiagramID);

		/// 
		/// <param name="PackageID"></param>
		void ReloadPackage(Int32 PackageID);

		/// 
		/// <param name="Name"></param>
		void RemoveOutputTab(String Name);

		/// 
		/// <param name="Name"></param>
		void RemoveTab(String Name);

		/// 
		/// <param name="TabName"></param>
		Boolean RemoveWindow(Object TabName);

		String RepositoryType();

		Collection Resources
		{
			get;
		}

		/// 
		/// <param name="QueryName"></param>
		/// <param name="SearchTerm"></param>
		/// <param name="SearchOptions"></param>
		/// <param name="SearchData"></param>
		void RunModelSearch(String QueryName, String SearchTerm, String SearchOptions, String SearchData);

		void SaveAllDiagrams();

		/// 
		/// <param name="FilePath"></param>
		/// <param name="StateDateTime"></param>
		/// <param name="EndDateTime"></param>
		Boolean SaveAuditLogs(String FilePath, Object StateDateTime, Object EndDateTime);

		/// 
		/// <param name="DiagramID"></param>
		void SaveDiagram(Int32 DiagramID);

		/// 
		/// <param name="dgmGUID"></param>
		/// <param name="FileName"></param>
		Boolean SaveDiagramAsUMLProfile(String dgmGUID, String FileName);

		/// 
		/// <param name="imagename"></param>
		/// <param name="Path"></param>
		Boolean SaveImageToPath(Object imagename, Object Path);

		/// 
		/// <param name="pkgGUID"></param>
		/// <param name="FileName"></param>
		Boolean SavePackageAsUMLProfile(String pkgGUID, String FileName);

		Boolean ScanXMIAndReconcile();

		//SchemaComposer SchemaComposer{
		//	get;
		//}

		/// 
		/// <param name="Terms"></param>
		void SetMarkupTerms(Object Terms);

		/// 
		/// <param name="flagSet"></param>
		/// <param name="objectID"></param>
		/// <param name="Flags"></param>
		Int32 SetObjectFlags(String flagSet, Int32 objectID, Int32 Flags);

		/// 
		/// <param name="Terms"></param>
		void SetReplacementTerms(Object Terms);

		/// 
		/// <param name="Perspective"></param>
		void SetUIPerspective(String Perspective);

		/// 
		/// <param name="TabName"></param>
		Boolean ShowAddinWindow(Object TabName);

		/// 
		/// <param name="TabName"></param>
		/// <param name="URL"></param>
		void ShowBrowser(String TabName, String URL);

		/// 
		/// <param name="Topic"></param>
		void ShowDynamicHelp(String Topic);

		/// 
		/// <param name="Object"></param>
		void ShowInProjectView(Object Object);

		/// 
		/// <param name="Technology"></param>
		/// <param name="Profile"></param>
		/// <param name="Show"></param>
		void ShowProfileToolbox(String Technology, String Profile, Boolean Show);

		/// 
		/// <param name="Show"></param>
		void ShowWindow(Int32 Show);

		//Simulation Simulation{
		//	get;
		//}

		/// 
		/// <param name="SQL"></param>
		String SQLQuery(String SQL);

		Collection Stereotypes
		{
			get;
		}

		Boolean SuppressEADialogs
		{
			get;
			set;
		}

		Boolean SuppressSecurityDialog
		{
			get;
			set;
		}

		/// 
		/// <param name="Profile"></param>
		/// <param name="Stereotype"></param>
		Boolean SynchProfile(Object Profile, Object Stereotype);

		Collection Tasks
		{
			get;
		}

		Collection Terms
		{
			get;
		}

		/// 
		/// <param name="ClearSettings"></param>
		void VersionControlResynchPkgStatuses(Boolean ClearSettings);

		/// 
		/// <param name="Name"></param>
		/// <param name="String"></param>
		/// <param name="ID"></param>
		void WriteOutput(String Name, String String, Int32 ID);
	}//end IDualRepository

}//end namespace Contracts