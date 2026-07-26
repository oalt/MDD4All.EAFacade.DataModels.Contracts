using System;

namespace MDD4All.EAFacade.DataModels.Contracts {
	public interface IDualProject  {

		void CancelValidation();

		Boolean CanValidate();

		///
		/// <param name="PackageGUID"></param>
		/// <param name="Version"></param>
		/// <param name="Notes"></param>
		Boolean CreateBaseline(String PackageGUID, String Version, String Notes);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="Version"></param>
		/// <param name="Notes"></param>
		/// <param name="Flags"></param>
		Boolean CreateBaselineEx(String PackageGUID, String Version, String Notes, Int32 Flags);

		///
		/// <param name="CategoryID"></param>
		/// <param name="Severity"></param>
		/// <param name="ErrorMsg"></param>
		String DefineRule(String CategoryID, EnumMVErrorType Severity, String ErrorMsg);

		///
		/// <param name="Description"></param>
		String DefineRuleCategory(String Description);

		///
		/// <param name="Baseline"></param>
		Boolean DeleteBaseline(String Baseline);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="Baseline"></param>
		/// <param name="ConnectString"></param>
		String DoBaselineCompare(String PackageGUID, String Baseline, String ConnectString);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="Baseline"></param>
		/// <param name="MergeInstructions"></param>
		/// <param name="ConnectString"></param>
		String DoBaselineMerge(String PackageGUID, String Baseline, String MergeInstructions, String ConnectString);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="XMIFile"></param>
		/// <param name="XMIComparisonFile"></param>
		String DoPackageCompareAndMerge(String PackageGUID, String XMIFile, String XMIComparisonFile);

		///
		/// <param name="DiagramGUID"></param>
		String EnumDiagramElements(String DiagramGUID);

		///
		/// <param name="DiagramID"></param>
		String EnumDiagramLinks(String DiagramID);

		///
		/// <param name="PackageGUID"></param>
		String EnumDiagrams(String PackageGUID);

		///
		/// <param name="PackageGUID"></param>
		String EnumElements(String PackageGUID);

		///
		/// <param name="PackageID"></param>
		String EnumLinks(String PackageID);

		///
		/// <param name="PackageGUID"></param>
		String EnumPackages(String PackageGUID);

		String EnumProjects();

		///
		/// <param name="ProjectGUID"></param>
		String EnumViewEx(String ProjectGUID);

		String EnumViews();

		void Exit();

		///
		/// <param name="PackageGUID"></param>
		/// <param name="XMIType"></param>
		/// <param name="DiagramXML"></param>
		/// <param name="DiagramImage"></param>
		/// <param name="FormatXML"></param>
		/// <param name="UseDTD"></param>
		/// <param name="FileName"></param>
		String ExportPackageXMI(String PackageGUID, EnumXMIType XMIType, Int32 DiagramXML, Int32 DiagramImage, Int32 FormatXML, Int32 UseDTD, String FileName);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="XMIType"></param>
		/// <param name="DiagramXML"></param>
		/// <param name="DiagramImage"></param>
		/// <param name="FormatXML"></param>
		/// <param name="UseDTD"></param>
		/// <param name="FileName"></param>
		/// <param name="Flags"></param>
		String ExportPackageXMIEx(String PackageGUID, EnumXMIType XMIType, Int32 DiagramXML, Int32 DiagramImage, Int32 FormatXML, Int32 UseDTD, String FileName, Int32 Flags);

		///
		/// <param name="ElementGUID"></param>
		/// <param name="ExtraOptions"></param>
		Boolean GenerateClass(String ElementGUID, String ExtraOptions);

		///
		/// <param name="ElementGUID"></param>
		/// <param name="DiagramType"></param>
		/// <param name="Options"></param>
		Boolean GenerateDiagramFromScenario(String ElementGUID, EnumScenarioDiagramType DiagramType, Int32 Options);

		///
		/// <param name="ElementGUID"></param>
		/// <param name="GenDDLFilePath"></param>
		/// <param name="ExtraOptions"></param>
		Boolean GenerateElementDDL(String ElementGUID, String GenDDLFilePath, String ExtraOptions);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="ExtraOptions"></param>
		Boolean GeneratePackage(String PackageGUID, String ExtraOptions);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="GenDDLFilePath"></param>
		/// <param name="ExtraOptions"></param>
		Boolean GeneratePackageDDL(String PackageGUID, String GenDDLFilePath, String ExtraOptions);

		///
		/// <param name="ElementGUID"></param>
		/// <param name="TestType"></param>
		Boolean GenerateTestFromScenario(String ElementGUID, EnumScenarioTestType TestType);

		///
		/// <param name="WSDLComponentGUID"></param>
		/// <param name="FileName"></param>
		/// <param name="Encoding"></param>
		/// <param name="ExtraOptions"></param>
		Boolean GenerateWSDL(String WSDLComponentGUID, String FileName, String Encoding, String ExtraOptions);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="FileName"></param>
		/// <param name="Encoding"></param>
		/// <param name="Options"></param>
		Boolean GenerateXSD(String PackageGUID, String FileName, String Encoding, String Options);

		///
		/// <param name="Directory"></param>
		Boolean GetAllDiagramImageAndMap(String Directory);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="ConnectString"></param>
		String GetBaselines(String PackageGUID, String ConnectString);

		///
		/// <param name="DiagramGUID"></param>
		String GetDiagram(String DiagramGUID);

		///
		/// <param name="DiagramGUID"></param>
		/// <param name="Directory"></param>
		Boolean GetDiagramImageAndMap(String DiagramGUID, String Directory);

		///
		/// <param name="ElementGUID"></param>
		String GetElement(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementConstraints(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementEffort(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementFiles(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementMetrics(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementProblems(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementProperties(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementRequirements(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementResources(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementRisks(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementScenarios(String ElementGUID);

		///
		/// <param name="ElementGUID"></param>
		String GetElementTests(String ElementGUID);

		///
		/// <param name="sName"></param>
		/// <param name="filter"></param>
		/// <param name="DefaultFilterIndex"></param>
		/// <param name="Flags"></param>
		/// <param name="defaultDir"></param>
		/// <param name="Type"></param>
		String GetFileNameDialog(String sName, String filter, Int32 DefaultFilterIndex, Int32 Flags, String defaultDir, EnumFilenameDialog Type);

		String GetLastError();

		///
		/// <param name="LinkGUID"></param>
		String GetLink(String LinkGUID);

		///
		/// <param name="GUID"></param>
		String GUIDtoXML(String GUID);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="Language"></param>
		/// <param name="DirectoryPath"></param>
		/// <param name="ExtraOptions"></param>
		Boolean ImportDirectory(String PackageGUID, String Language, String DirectoryPath, String ExtraOptions);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="Language"></param>
		/// <param name="FileName"></param>
		/// <param name="ExtraOptions"></param>
		Boolean ImportFile(String PackageGUID, String Language, String FileName, String ExtraOptions);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="FileName"></param>
		/// <param name="ImportDiagrams"></param>
		/// <param name="StripGUID"></param>
		String ImportPackageXMI(String PackageGUID, String FileName, Int32 ImportDiagrams, Int32 StripGUID);

		Boolean IsValidating();

		///
		/// <param name="DiagramGUID"></param>
		/// <param name="LayoutStyle"></param>
		Boolean LayoutDiagram(String DiagramGUID, Int32 LayoutStyle);

		///
		/// <param name="DiagramGUID"></param>
		/// <param name="LayoutStyle"></param>
		/// <param name="Iterations"></param>
		/// <param name="LayerSpacing"></param>
		/// <param name="ColumnSpacing"></param>
		/// <param name="SavetoDiagram"></param>
		Boolean LayoutDiagramEx(String DiagramGUID, Int32 LayoutStyle, Int32 Iterations, Int32 LayerSpacing, Int32 ColumnSpacing, Boolean SavetoDiagram);

		///
		/// <param name="PackageGUID"></param>
		String LoadControlledPackage(String PackageGUID);

		///
		/// <param name="DiagramGUID"></param>
		Boolean LoadDiagram(String DiagramGUID);

		///
		/// <param name="FileName"></param>
		Boolean LoadProject(String FileName);

		///
		/// <param name="GUID"></param>
		/// <param name="SourceType"></param>
		/// <param name="DestType"></param>
		void Migrate(String GUID, String SourceType, String DestType);

		///
		/// <param name="GUID"></param>
		/// <param name="Type"></param>
		void MigrateToBPMN11(String GUID, String Type);

		ObjectType ObjectType {
			get;
		}

		///
		/// <param name="SourceFilePath"></param>
		/// <param name="TargetFilePath"></param>
		/// <param name="LogFilePath"></param>
		Boolean ProjectTransfer(String SourceFilePath, String TargetFilePath, String LogFilePath);

		///
		/// <param name="RuleID"></param>
		/// <param name="Severity"></param>
		/// <param name="ErrorMsg"></param>
		Boolean PublishResult(String RuleID, EnumMVErrorType Severity, String ErrorMsg);

		///
		/// <param name="DiagramGUID"></param>
		/// <param name="Type"></param>
		Boolean PutDiagramImageOnClipboard(String DiagramGUID, Int32 Type);

		///
		/// <param name="DiagramGUID"></param>
		/// <param name="FilePath"></param>
		/// <param name="Type"></param>
		Boolean PutDiagramImageToFile(String DiagramGUID, String FilePath, Int32 Type);

		Boolean ReloadProject();

		///
		/// <param name="PackageGUID"></param>
		/// <param name="ExportPath"></param>
		/// <param name="ImageFormat"></param>
		/// <param name="Style"></param>
		/// <param name="Extension"></param>
		void RunHTMLReport(String PackageGUID, String ExportPath, String ImageFormat, String Style, String Extension);

		///
		/// <param name="QueryName"></param>
		/// <param name="SearchTerm"></param>
		/// <param name="ShowInEA"></param>
		void RunModelSearch(String QueryName, String SearchTerm, Boolean ShowInEA);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="TemplateName"></param>
		/// <param name="FileName"></param>
		void RunReport(String PackageGUID, String TemplateName, String FileName);

		///
		/// <param name="PackageGUID"></param>
		String SaveControlledPackage(String PackageGUID);

		///
		/// <param name="FileName"></param>
		String SaveDiagramImageToFile(String FileName);

		///
		/// <param name="Show"></param>
		void ShowWindow(Int32 Show);

		///
		/// <param name="ElementGUID"></param>
		/// <param name="ExtraOptions"></param>
		Boolean SynchronizeClass(String ElementGUID, String ExtraOptions);

		///
		/// <param name="PackageGUID"></param>
		/// <param name="ExtraOptions"></param>
		Boolean SynchronizePackage(String PackageGUID, String ExtraOptions);

		///
		/// <param name="transformName"></param>
		/// <param name="ElementGUID"></param>
		/// <param name="TargetPackageGUID"></param>
		/// <param name="ExtraOptions"></param>
		Boolean TransformElement(String transformName, String ElementGUID, String TargetPackageGUID, String ExtraOptions);

		///
		/// <param name="transformName"></param>
		/// <param name="SourcePackageGUID"></param>
		/// <param name="TargetPackageGUID"></param>
		/// <param name="ExtraOptions"></param>
		Boolean TransformPackage(String transformName, String SourcePackageGUID, String TargetPackageGUID, String ExtraOptions);

		///
		/// <param name="DiagramGUID"></param>
		Boolean ValidateDiagram(String DiagramGUID);

		///
		/// <param name="ElementGUID"></param>
		Boolean ValidateElement(String ElementGUID);

		///
		/// <param name="PackageGUID"></param>
		Boolean ValidatePackage(String PackageGUID);

		///
		/// <param name="GUID"></param>
		String XMLtoGUID(String GUID);
	}//end IDualProject

}//end namespace Contracts
