///////////////////////////////////////////////////////////
//  _Property.cs
//  Implementation of the Interface _Property
//  Generated by Enterprise Architect
//  Created on:      16-Jun-2020 11:31:05
//  Original author: alto
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



namespace MDD4All.EnterpriseArchitect.DataModels.Contracts
{
    public interface _Property
    {

        string Name
        {
            get;
        }

        ObjectType ObjectType
        {
            get;
        }

        PropType Type
        {
            get;
        }

        string Validation
        {
            get;
        }

        object Value
        {
            get;
            set;
        }
    }
}