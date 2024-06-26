// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Fleet.Runtime.PowerShell;

    /// <summary>The properties of the UpdateRun.</summary>
    [System.ComponentModel.TypeConverter(typeof(UpdateRunPropertiesTypeConverter))]
    public partial class UpdateRunProperties
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateRunProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new UpdateRunProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateRunProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunProperties" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new UpdateRunProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="UpdateRunProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="UpdateRunProperties" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Fleet.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateRunProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal UpdateRunProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Strategy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Strategy = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunStrategy) content.GetValueForProperty("Strategy",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Strategy, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateRunStrategyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedClusterUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdate = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IManagedClusterUpdate) content.GetValueForProperty("ManagedClusterUpdate",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdate, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ManagedClusterUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateRunStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateStrategyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpdateStrategyId = (string) content.GetValueForProperty("UpdateStrategyId",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpdateStrategyId, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpdateStatus = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStatus) content.GetValueForProperty("UpdateStatus",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpdateStatus, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("StrategyStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StrategyStage = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStage>) content.GetValueForProperty("StrategyStage",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StrategyStage, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStage>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateStageTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManagedClusterUpdateUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdateUpgrade = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IManagedClusterUpgradeSpec) content.GetValueForProperty("ManagedClusterUpdateUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdateUpgrade, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ManagedClusterUpgradeSpecTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedClusterUpdateNodeImageSelection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdateNodeImageSelection = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.INodeImageSelection) content.GetValueForProperty("ManagedClusterUpdateNodeImageSelection",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdateNodeImageSelection, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.NodeImageSelectionTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpgradeKubernetesVersion = (string) content.GetValueForProperty("UpgradeKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpgradeKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NodeImageSelectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).NodeImageSelectionType = (string) content.GetValueForProperty("NodeImageSelectionType",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).NodeImageSelectionType, global::System.Convert.ToString);
            }
            if (content.Contains("StatusNodeImageSelection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusNodeImageSelection = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.INodeImageSelectionStatus) content.GetValueForProperty("StatusNodeImageSelection",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusNodeImageSelection, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.NodeImageSelectionStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusStage = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStageStatus>) content.GetValueForProperty("StatusStage",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusStage, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStageStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateStageStatusTypeConverter.ConvertFrom));
            }
            if (content.Contains("StatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusError = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorDetail) content.GetValueForProperty("StatusError",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusError, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusStartTime = (global::System.DateTime?) content.GetValueForProperty("StatusStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StatusCompletedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusCompletedTime = (global::System.DateTime?) content.GetValueForProperty("StatusCompletedTime",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusCompletedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StatusState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusState = (string) content.GetValueForProperty("StatusState",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusState, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpgradeType = (string) content.GetValueForProperty("UpgradeType",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpgradeType, global::System.Convert.ToString);
            }
            if (content.Contains("NodeImageSelectionSelectedNodeImageVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).NodeImageSelectionSelectedNodeImageVersion = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.INodeImageVersion>) content.GetValueForProperty("NodeImageSelectionSelectedNodeImageVersion",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).NodeImageSelectionSelectedNodeImageVersion, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.INodeImageVersion>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.NodeImageVersionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorDetail>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateRunProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal UpdateRunProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Strategy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Strategy = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunStrategy) content.GetValueForProperty("Strategy",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Strategy, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateRunStrategyTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedClusterUpdate"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdate = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IManagedClusterUpdate) content.GetValueForProperty("ManagedClusterUpdate",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdate, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ManagedClusterUpdateTypeConverter.ConvertFrom);
            }
            if (content.Contains("Status"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Status = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunStatus) content.GetValueForProperty("Status",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Status, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateRunStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("ProvisioningState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ProvisioningState = (string) content.GetValueForProperty("ProvisioningState",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ProvisioningState, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateStrategyId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpdateStrategyId = (string) content.GetValueForProperty("UpdateStrategyId",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpdateStrategyId, global::System.Convert.ToString);
            }
            if (content.Contains("UpdateStatus"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpdateStatus = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStatus) content.GetValueForProperty("UpdateStatus",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpdateStatus, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("StrategyStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StrategyStage = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStage>) content.GetValueForProperty("StrategyStage",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StrategyStage, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStage>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateStageTypeConverter.ConvertFrom));
            }
            if (content.Contains("ManagedClusterUpdateUpgrade"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdateUpgrade = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IManagedClusterUpgradeSpec) content.GetValueForProperty("ManagedClusterUpdateUpgrade",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdateUpgrade, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ManagedClusterUpgradeSpecTypeConverter.ConvertFrom);
            }
            if (content.Contains("ManagedClusterUpdateNodeImageSelection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdateNodeImageSelection = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.INodeImageSelection) content.GetValueForProperty("ManagedClusterUpdateNodeImageSelection",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).ManagedClusterUpdateNodeImageSelection, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.NodeImageSelectionTypeConverter.ConvertFrom);
            }
            if (content.Contains("UpgradeKubernetesVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpgradeKubernetesVersion = (string) content.GetValueForProperty("UpgradeKubernetesVersion",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpgradeKubernetesVersion, global::System.Convert.ToString);
            }
            if (content.Contains("NodeImageSelectionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).NodeImageSelectionType = (string) content.GetValueForProperty("NodeImageSelectionType",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).NodeImageSelectionType, global::System.Convert.ToString);
            }
            if (content.Contains("StatusNodeImageSelection"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusNodeImageSelection = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.INodeImageSelectionStatus) content.GetValueForProperty("StatusNodeImageSelection",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusNodeImageSelection, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.NodeImageSelectionStatusTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusStage = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStageStatus>) content.GetValueForProperty("StatusStage",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusStage, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateStageStatus>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.UpdateStageStatusTypeConverter.ConvertFrom));
            }
            if (content.Contains("StatusError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusError = (Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorDetail) content.GetValueForProperty("StatusError",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusError, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ErrorDetailTypeConverter.ConvertFrom);
            }
            if (content.Contains("StatusStartTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusStartTime = (global::System.DateTime?) content.GetValueForProperty("StatusStartTime",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusStartTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StatusCompletedTime"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusCompletedTime = (global::System.DateTime?) content.GetValueForProperty("StatusCompletedTime",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusCompletedTime, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("StatusState"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusState = (string) content.GetValueForProperty("StatusState",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).StatusState, global::System.Convert.ToString);
            }
            if (content.Contains("UpgradeType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpgradeType = (string) content.GetValueForProperty("UpgradeType",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).UpgradeType, global::System.Convert.ToString);
            }
            if (content.Contains("NodeImageSelectionSelectedNodeImageVersion"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).NodeImageSelectionSelectedNodeImageVersion = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.INodeImageVersion>) content.GetValueForProperty("NodeImageSelectionSelectedNodeImageVersion",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).NodeImageSelectionSelectedNodeImageVersion, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.INodeImageVersion>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.NodeImageVersionTypeConverter.ConvertFrom));
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Detail = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorDetail>) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).Detail, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("AdditionalInfo"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).AdditionalInfo = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorAdditionalInfo>) content.GetValueForProperty("AdditionalInfo",((Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IUpdateRunPropertiesInternal)this).AdditionalInfo, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.IErrorAdditionalInfo>(__y, Microsoft.Azure.PowerShell.Cmdlets.Fleet.Models.ErrorAdditionalInfoTypeConverter.ConvertFrom));
            }
            AfterDeserializePSObject(content);
        }
    }
    /// The properties of the UpdateRun.
    [System.ComponentModel.TypeConverter(typeof(UpdateRunPropertiesTypeConverter))]
    public partial interface IUpdateRunProperties

    {

    }
}