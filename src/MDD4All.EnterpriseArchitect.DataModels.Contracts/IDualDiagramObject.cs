using System;

namespace MDD4All.EnterpriseArchitect.DataModels.Contracts {
	public interface IDualDiagramObject  {

		Int32 BackgroundColor{
			get;
			set;
		}

		Int32 BorderColor{
			get;
			set;
		}

		Int32 BorderLineWidth{
			get;
			set;
		}

		Int32 bottom{
			get;
			set;
		}

		Int32 DiagramID{
			get;
			set;
		}

		FeatureDisplayMode ElementDisplayMode{
			get;
			set;
		}

		Int32 ElementID{
			get;
			set;
		}

		String FeatureStereotypesToHide{
			get;
			set;
		}

		Boolean FontBold{
			get;
			set;
		}

		Int32 FontColor{
			get;
			set;
		}

		Boolean FontItalic{
			get;
			set;
		}

		Object fontName{
			get;
			set;
		}

		Int32 fontSize{
			get;
			set;
		}

		Boolean FontUnderline{
			get;
			set;
		}

		String GetLastError();

		Object InstanceGUID{
			get;
		}

		Int32 InstanceID{
			get;
			set;
		}

		Boolean IsSelectable{
			get;
			set;
		}

		Int32 left{
			get;
			set;
		}

		ObjectType ObjectType{
			get;
		}

		void ResetFont();

		Int32 right{
			get;
			set;
		}

		Int32 Sequence{
			get;
			set;
		}

		/// 
		/// <param name="fontName"></param>
		/// <param name="fontSize"></param>
		/// <param name="bold"></param>
		/// <param name="italic"></param>
		/// <param name="underline"></param>
		Boolean SetFontStyle(Object fontName, Int32 fontSize, Boolean bold, Boolean italic, Boolean underline);

		/// 
		/// <param name="sParameter"></param>
		/// <param name="sValue"></param>
		void SetStyleEx(String sParameter, String sValue);

		Boolean ShowComposedDiagram{
			get;
			set;
		}

		Boolean ShowConstraints{
			get;
			set;
		}

		Boolean ShowFormattedNotes{
			get;
			set;
		}

		Boolean ShowFullyQualifiedTags{
			get;
			set;
		}

		Boolean ShowInheritedAttributes{
			get;
			set;
		}

		Boolean ShowInheritedConstraints{
			get;
			set;
		}

		Boolean ShowInheritedOperations{
			get;
			set;
		}

		Boolean ShowInheritedResponsibilities{
			get;
			set;
		}

		Boolean ShowInheritedTags{
			get;
			set;
		}

		Boolean ShowNotes{
			get;
			set;
		}

		Boolean ShowPackageAttributes{
			get;
			set;
		}

		Boolean ShowPackageOperations{
			get;
			set;
		}

		Boolean ShowPortType{
			get;
			set;
		}

		Boolean ShowPrivateAttributes{
			get;
			set;
		}

		Boolean ShowPrivateOperations{
			get;
			set;
		}

		Boolean ShowProtectedAttributes{
			get;
			set;
		}

		Boolean ShowProtectedOperations{
			get;
			set;
		}

		Boolean ShowPublicAttributes{
			get;
			set;
		}

		Boolean ShowPublicOperations{
			get;
			set;
		}

		Boolean ShowResponsibilities{
			get;
			set;
		}

		Boolean ShowRunstates{
			get;
			set;
		}

		Boolean ShowStructuredCompartments{
			get;
			set;
		}

		Boolean ShowTags{
			get;
			set;
		}

		Object Style{
			get;
			set;
		}

		TextAlignment TextAlign{
			get;
			set;
		}

		Int32 top{
			get;
			set;
		}

		Boolean Update();
	}//end IDualDiagramObject

}//end namespace Contracts