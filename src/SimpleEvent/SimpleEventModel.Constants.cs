/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace SimpleEventModel
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the CycleStepDataType DataType.
        /// </summary>
        public const uint CycleStepDataType = 1;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the CycleStepDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint CycleStepDataType_Encoding_DefaultBinary = 52;

        /// <summary>
        /// The identifier for the CycleStepDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint CycleStepDataType_Encoding_DefaultXml = 60;

        /// <summary>
        /// The identifier for the CycleStepDataType_Encoding_DefaultJson Object.
        /// </summary>
        public const uint CycleStepDataType_Encoding_DefaultJson = 68;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the SystemCycleStatusEventType ObjectType.
        /// </summary>
        public const uint SystemCycleStatusEventType = 2;

        /// <summary>
        /// The identifier for the SystemCycleStartedEventType ObjectType.
        /// </summary>
        public const uint SystemCycleStartedEventType = 14;

        /// <summary>
        /// The identifier for the SystemCycleAbortedEventType ObjectType.
        /// </summary>
        public const uint SystemCycleAbortedEventType = 27;

        /// <summary>
        /// The identifier for the SystemCycleFinishedEventType ObjectType.
        /// </summary>
        public const uint SystemCycleFinishedEventType = 40;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the SystemCycleStatusEventType_CycleId Variable.
        /// </summary>
        public const uint SystemCycleStatusEventType_CycleId = 12;

        /// <summary>
        /// The identifier for the SystemCycleStatusEventType_CurrentStep Variable.
        /// </summary>
        public const uint SystemCycleStatusEventType_CurrentStep = 13;

        /// <summary>
        /// The identifier for the SystemCycleStartedEventType_Steps Variable.
        /// </summary>
        public const uint SystemCycleStartedEventType_Steps = 26;

        /// <summary>
        /// The identifier for the SystemCycleAbortedEventType_Error Variable.
        /// </summary>
        public const uint SystemCycleAbortedEventType_Error = 39;

        /// <summary>
        /// The identifier for the SimpleEvent_BinarySchema Variable.
        /// </summary>
        public const uint SimpleEvent_BinarySchema = 53;

        /// <summary>
        /// The identifier for the SimpleEvent_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint SimpleEvent_BinarySchema_NamespaceUri = 55;

        /// <summary>
        /// The identifier for the SimpleEvent_BinarySchema_Deprecated Variable.
        /// </summary>
        public const uint SimpleEvent_BinarySchema_Deprecated = 56;

        /// <summary>
        /// The identifier for the SimpleEvent_BinarySchema_CycleStepDataType Variable.
        /// </summary>
        public const uint SimpleEvent_BinarySchema_CycleStepDataType = 57;

        /// <summary>
        /// The identifier for the SimpleEvent_XmlSchema Variable.
        /// </summary>
        public const uint SimpleEvent_XmlSchema = 61;

        /// <summary>
        /// The identifier for the SimpleEvent_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint SimpleEvent_XmlSchema_NamespaceUri = 63;

        /// <summary>
        /// The identifier for the SimpleEvent_XmlSchema_Deprecated Variable.
        /// </summary>
        public const uint SimpleEvent_XmlSchema_Deprecated = 64;

        /// <summary>
        /// The identifier for the SimpleEvent_XmlSchema_CycleStepDataType Variable.
        /// </summary>
        public const uint SimpleEvent_XmlSchema_CycleStepDataType = 65;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the CycleStepDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId CycleStepDataType = new ExpandedNodeId(SimpleEventModel.DataTypes.CycleStepDataType, SimpleEventModel.Namespaces.SimpleEvent);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the CycleStepDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId CycleStepDataType_Encoding_DefaultBinary = new ExpandedNodeId(SimpleEventModel.Objects.CycleStepDataType_Encoding_DefaultBinary, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the CycleStepDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId CycleStepDataType_Encoding_DefaultXml = new ExpandedNodeId(SimpleEventModel.Objects.CycleStepDataType_Encoding_DefaultXml, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the CycleStepDataType_Encoding_DefaultJson Object.
        /// </summary>
        public static readonly ExpandedNodeId CycleStepDataType_Encoding_DefaultJson = new ExpandedNodeId(SimpleEventModel.Objects.CycleStepDataType_Encoding_DefaultJson, SimpleEventModel.Namespaces.SimpleEvent);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the SystemCycleStatusEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SystemCycleStatusEventType = new ExpandedNodeId(SimpleEventModel.ObjectTypes.SystemCycleStatusEventType, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SystemCycleStartedEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SystemCycleStartedEventType = new ExpandedNodeId(SimpleEventModel.ObjectTypes.SystemCycleStartedEventType, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SystemCycleAbortedEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SystemCycleAbortedEventType = new ExpandedNodeId(SimpleEventModel.ObjectTypes.SystemCycleAbortedEventType, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SystemCycleFinishedEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId SystemCycleFinishedEventType = new ExpandedNodeId(SimpleEventModel.ObjectTypes.SystemCycleFinishedEventType, SimpleEventModel.Namespaces.SimpleEvent);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the SystemCycleStatusEventType_CycleId Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemCycleStatusEventType_CycleId = new ExpandedNodeId(SimpleEventModel.Variables.SystemCycleStatusEventType_CycleId, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SystemCycleStatusEventType_CurrentStep Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemCycleStatusEventType_CurrentStep = new ExpandedNodeId(SimpleEventModel.Variables.SystemCycleStatusEventType_CurrentStep, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SystemCycleStartedEventType_Steps Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemCycleStartedEventType_Steps = new ExpandedNodeId(SimpleEventModel.Variables.SystemCycleStartedEventType_Steps, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SystemCycleAbortedEventType_Error Variable.
        /// </summary>
        public static readonly ExpandedNodeId SystemCycleAbortedEventType_Error = new ExpandedNodeId(SimpleEventModel.Variables.SystemCycleAbortedEventType_Error, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SimpleEvent_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimpleEvent_BinarySchema = new ExpandedNodeId(SimpleEventModel.Variables.SimpleEvent_BinarySchema, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SimpleEvent_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimpleEvent_BinarySchema_NamespaceUri = new ExpandedNodeId(SimpleEventModel.Variables.SimpleEvent_BinarySchema_NamespaceUri, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SimpleEvent_BinarySchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimpleEvent_BinarySchema_Deprecated = new ExpandedNodeId(SimpleEventModel.Variables.SimpleEvent_BinarySchema_Deprecated, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SimpleEvent_BinarySchema_CycleStepDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimpleEvent_BinarySchema_CycleStepDataType = new ExpandedNodeId(SimpleEventModel.Variables.SimpleEvent_BinarySchema_CycleStepDataType, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SimpleEvent_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimpleEvent_XmlSchema = new ExpandedNodeId(SimpleEventModel.Variables.SimpleEvent_XmlSchema, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SimpleEvent_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimpleEvent_XmlSchema_NamespaceUri = new ExpandedNodeId(SimpleEventModel.Variables.SimpleEvent_XmlSchema_NamespaceUri, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SimpleEvent_XmlSchema_Deprecated Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimpleEvent_XmlSchema_Deprecated = new ExpandedNodeId(SimpleEventModel.Variables.SimpleEvent_XmlSchema_Deprecated, SimpleEventModel.Namespaces.SimpleEvent);

        /// <summary>
        /// The identifier for the SimpleEvent_XmlSchema_CycleStepDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId SimpleEvent_XmlSchema_CycleStepDataType = new ExpandedNodeId(SimpleEventModel.Variables.SimpleEvent_XmlSchema_CycleStepDataType, SimpleEventModel.Namespaces.SimpleEvent);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the CurrentStep component.
        /// </summary>
        public const string CurrentStep = "CurrentStep";

        /// <summary>
        /// The BrowseName for the CycleId component.
        /// </summary>
        public const string CycleId = "CycleId";

        /// <summary>
        /// The BrowseName for the CycleStepDataType component.
        /// </summary>
        public const string CycleStepDataType = "CycleStepDataType";

        /// <summary>
        /// The BrowseName for the Error component.
        /// </summary>
        public const string Error = "Error";

        /// <summary>
        /// The BrowseName for the SimpleEvent_BinarySchema component.
        /// </summary>
        public const string SimpleEvent_BinarySchema = "SimpleEventModel";

        /// <summary>
        /// The BrowseName for the SimpleEvent_XmlSchema component.
        /// </summary>
        public const string SimpleEvent_XmlSchema = "SimpleEventModel";

        /// <summary>
        /// The BrowseName for the Steps component.
        /// </summary>
        public const string Steps = "Steps";

        /// <summary>
        /// The BrowseName for the SystemCycleAbortedEventType component.
        /// </summary>
        public const string SystemCycleAbortedEventType = "SystemCycleAbortedEventType";

        /// <summary>
        /// The BrowseName for the SystemCycleFinishedEventType component.
        /// </summary>
        public const string SystemCycleFinishedEventType = "SystemCycleFinishedEventType";

        /// <summary>
        /// The BrowseName for the SystemCycleStartedEventType component.
        /// </summary>
        public const string SystemCycleStartedEventType = "SystemCycleStartedEventType";

        /// <summary>
        /// The BrowseName for the SystemCycleStatusEventType component.
        /// </summary>
        public const string SystemCycleStatusEventType = "SystemCycleStatusEventType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the SimpleEvent namespace (.NET code namespace is 'SimpleEventModel').
        /// </summary>
        public const string SimpleEvent = "http://microsoft.com/Opc/OpcPlc/SimpleEvent";
    }
    #endregion
}