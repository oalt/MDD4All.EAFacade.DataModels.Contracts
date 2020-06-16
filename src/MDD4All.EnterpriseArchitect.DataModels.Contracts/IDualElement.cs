using System;

namespace MDD4All.EnterpriseArchitect.DataModels.Contracts
{
    public interface IDualElement
    {

        string Abstract
        {
            get;
            set;
        }

        string ActionFlags
        {
            get;
            set;
        }

        string Alias
        {
            get;
            set;
        }

        

        int AssociationClassConnectorID
        {
            get;
        }

        Collection Attributes
        {
            get;
        }

        Collection AttributesEx
        {
            get;
        }

        string Author
        {
            get;
            set;
        }

        Collection BaseClasses
        {
            get;
        }

        int ClassfierID
        {
            get;
            set;
        }

        int ClassifierID
        {
            get;
            set;
        }

        string ClassifierName
        {
            get;
            set;
        }

        string ClassifierType
        {
            get;
        }

        Element Clone();

        string Complexity
        {
            get;
            set;
        }

        Object CompositeDiagram
        {
            get;
        }

        Collection Connectors
        {
            get;
        }

        Collection Constraints
        {
            get;
        }

        Collection ConstraintsEx
        {
            get;
        }

        /// 
        /// <param name="ConnectorID"></param>
        bool CreateAssociationClass(int ConnectorID);

        DateTime Created
        {
            get;
            set;
        }

        Collection CustomProperties
        {
            get;
        }

        bool DeleteLinkedDocument();

        Collection Diagrams
        {
            get;
        }

        string Difficulty
        {
            get;
            set;
        }

        Collection Efforts
        {
            get;
        }

        string ElementGUID
        {
            get;
        }

        int ElementID
        {
            get;
        }

        GenericCollection<Element> Elements
        {
            get;
        }

        GenericCollection<Element> EmbeddedElements
        {
            get;
        }

        string EventFlags
        {
            get;
            set;
        }

        /// 
        /// <param name="filenamne"></param>
        bool ExportInternalDocumentArtifact(string filenamne);

        string ExtensionPoints
        {
            get;
            set;
        }

        Collection Files
        {
            get;
        }

        string FQName
        {
            get;
        }

        string FQStereotype
        {
            get;
        }

        string Genfile
        {
            get;
            set;
        }

        string Genlinks
        {
            get;
            set;
        }

        string Gentype
        {
            get;
            set;
        }

        string GetBusinessRules();

        string GetDecisionTable();

        string GetLastError();

        string GetLinkedDocument();

        /// 
        /// <param name="Type"></param>
        string GetRelationSet(EnumRelationSetType Type);

        string GetStereotypeList();

        /// 
        /// <param name="stereo"></param>
        bool HasStereotype(string stereo);

        Object Header1
        {
            get;
            set;
        }

        Object Header2
        {
            get;
            set;
        }

        /// 
        /// <param name="filenamne"></param>
        bool ImportInternalDocumentArtifact(string filenamne);

        bool IsActive
        {
            get;
            set;
        }

        bool IsAssociationClass();

        bool IsComposite
        {
            get;
            set;
        }

        bool IsInternalDocArtifact
        {
            get;
        }

        bool IsLeaf
        {
            get;
            set;
        }

        bool IsNew
        {
            get;
            set;
        }

        bool IsRoot
        {
            set;
        }

        bool IsSpec
        {
            get;
            set;
        }

        Collection Issues
        {
            get;
        }

        /// 
        /// <param name="FileName"></param>
        bool LoadLinkedDocument(string FileName);

        bool Locked
        {
            get;
            set;
        }

        string MetaType
        {
            get;
            set;
        }

        Collection Methods
        {
            get;
        }

        Collection MethodsEx
        {
            get;
        }

        Collection Metrics
        {
            get;
        }

        string MiscData
        {
            get;
        }

        DateTime Modified
        {
            get;
            set;
        }

        string Multiplicity
        {
            get;
            set;
        }

        string Name
        {
            get;
            set;
        }

        string Notes
        {
            get;
            set;
        }

        ObjectType ObjectType
        {
            get;
        }

        int PackageID
        {
            get;
            set;
        }

        int ParentID
        {
            get;
            set;
        }

        Collection Partitions
        {
            get;
        }

        string Persistence
        {
            get;
            set;
        }

        string Phase
        {
            get;
            set;
        }

        string Priority
        {
            get;
            set;
        }

        Properties Properties
        {
            get;
        }

        int PropertyType
        {
            get;
            set;
        }

        Object PropertyTypeName
        {
            get;
        }

        Collection Realizes
        {
            get;
        }

        void Refresh();

        bool ReleaseUserLock();

        Collection Requirements
        {
            get;
        }

        Collection RequirementsEx
        {
            get;
        }

        Collection Resources
        {
            get;
        }

        Collection Risks
        {
            get;
        }

        string RunState
        {
            get;
            set;
        }

        /// 
        /// <param name="FileName"></param>
        bool SaveLinkedDocument(string FileName);

        Collection Scenarios
        {
            get;
        }



        Collection StateTransitions
        {
            get;
        }

        string Status
        {
            get;
            set;
        }

        string Stereotype
        {
            get;
            set;
        }

        string StereotypeEx
        {
            get;
            set;
        }

        string StyleEx
        {
            get;
            set;
        }

        int Subtype
        {
            get;
            set;
        }



        string Tablespace
        {
            get;
            set;
        }

        string Tag
        {
            get;
            set;
        }

        GenericCollection<TaggedValue> TaggedValues
        {
            get;
        }

        Collection TaggedValuesEx
        {
            get;
        }

        Collection TemplateParameters
        {
            get;
        }

        Collection Tests
        {
            get;
        }

        int TreePos
        {
            get;
            set;
        }

        string Type
        {
            get;
            set;
        }



        string Version
        {
            get;
            set;
        }

        string Visibility
        {
            get;
            set;
        }

        /// 
        /// <param name="aGroupName"></param>
        bool ApplyGroupLock(string aGroupName);

        bool ApplyUserLock();



        /// 
        /// <param name="Scope"></param>
        /// <param name="Item"></param>
        /// <param name="Value"></param>
        void SetAppearance(int Scope, int Item, int Value);

        /// 
        /// <param name="sGUID"></param>
        bool SetCompositeDiagram(string sGUID);

        /// 
        /// <param name="sProfile"></param>
        /// <param name="sStereotype"></param>
        bool SynchConstraints(string sProfile, string sStereotype);

        /// 
        /// <param name="sProfile"></param>
        /// <param name="sStereotype"></param>
        bool SynchTaggedValues(string sProfile, string sStereotype);

        bool UnlinkFromAssociation();

        bool Update();
    }
}