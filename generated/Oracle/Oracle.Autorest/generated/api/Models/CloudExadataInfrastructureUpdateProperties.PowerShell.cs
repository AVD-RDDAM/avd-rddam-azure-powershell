// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.PowerShell;

    /// <summary>The updatable properties of the CloudExadataInfrastructure.</summary>
    [System.ComponentModel.TypeConverter(typeof(CloudExadataInfrastructureUpdatePropertiesTypeConverter))]
    public partial class CloudExadataInfrastructureUpdateProperties
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.CloudExadataInfrastructureUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal CloudExadataInfrastructureUpdateProperties(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MaintenanceWindow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MaintenanceWindowTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComputeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).ComputeCount = (int?) content.GetValueForProperty("ComputeCount",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).ComputeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StorageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).StorageCount = (int?) content.GetValueForProperty("StorageCount",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).StorageCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CustomerContact"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).CustomerContact = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICustomerContact>) content.GetValueForProperty("CustomerContact",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).CustomerContact, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICustomerContact>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.CustomerContactTypeConverter.ConvertFrom));
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowPreference = (string) content.GetValueForProperty("MaintenanceWindowPreference",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowPreference, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowMonth = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMonth>) content.GetValueForProperty("MaintenanceWindowMonth",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowMonth, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMonth>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MonthTypeConverter.ConvertFrom));
            }
            if (content.Contains("MaintenanceWindowPatchingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowPatchingMode = (string) content.GetValueForProperty("MaintenanceWindowPatchingMode",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowPatchingMode, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowWeeksOfMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowWeeksOfMonth = (System.Collections.Generic.List<int>) content.GetValueForProperty("MaintenanceWindowWeeksOfMonth",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowWeeksOfMonth, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("MaintenanceWindowDaysOfWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowDaysOfWeek = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDayOfWeek>) content.GetValueForProperty("MaintenanceWindowDaysOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowDaysOfWeek, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDayOfWeek>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.DayOfWeekTypeConverter.ConvertFrom));
            }
            if (content.Contains("MaintenanceWindowHoursOfDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowHoursOfDay = (System.Collections.Generic.List<int>) content.GetValueForProperty("MaintenanceWindowHoursOfDay",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowHoursOfDay, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("MaintenanceWindowLeadTimeInWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowLeadTimeInWeek = (int?) content.GetValueForProperty("MaintenanceWindowLeadTimeInWeek",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowLeadTimeInWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaintenanceWindowCustomActionTimeoutInMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowCustomActionTimeoutInMin = (int?) content.GetValueForProperty("MaintenanceWindowCustomActionTimeoutInMin",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowCustomActionTimeoutInMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaintenanceWindowIsCustomActionTimeoutEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowIsCustomActionTimeoutEnabled = (bool?) content.GetValueForProperty("MaintenanceWindowIsCustomActionTimeoutEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowIsCustomActionTimeoutEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MaintenanceWindowIsMonthlyPatchingEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowIsMonthlyPatchingEnabled = (bool?) content.GetValueForProperty("MaintenanceWindowIsMonthlyPatchingEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowIsMonthlyPatchingEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.CloudExadataInfrastructureUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal CloudExadataInfrastructureUpdateProperties(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("MaintenanceWindow"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindow = (Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindow) content.GetValueForProperty("MaintenanceWindow",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindow, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MaintenanceWindowTypeConverter.ConvertFrom);
            }
            if (content.Contains("ComputeCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).ComputeCount = (int?) content.GetValueForProperty("ComputeCount",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).ComputeCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("StorageCount"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).StorageCount = (int?) content.GetValueForProperty("StorageCount",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).StorageCount, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("CustomerContact"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).CustomerContact = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICustomerContact>) content.GetValueForProperty("CustomerContact",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).CustomerContact, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICustomerContact>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.CustomerContactTypeConverter.ConvertFrom));
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowPreference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowPreference = (string) content.GetValueForProperty("MaintenanceWindowPreference",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowPreference, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowMonth = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMonth>) content.GetValueForProperty("MaintenanceWindowMonth",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowMonth, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMonth>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MonthTypeConverter.ConvertFrom));
            }
            if (content.Contains("MaintenanceWindowPatchingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowPatchingMode = (string) content.GetValueForProperty("MaintenanceWindowPatchingMode",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowPatchingMode, global::System.Convert.ToString);
            }
            if (content.Contains("MaintenanceWindowWeeksOfMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowWeeksOfMonth = (System.Collections.Generic.List<int>) content.GetValueForProperty("MaintenanceWindowWeeksOfMonth",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowWeeksOfMonth, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("MaintenanceWindowDaysOfWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowDaysOfWeek = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDayOfWeek>) content.GetValueForProperty("MaintenanceWindowDaysOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowDaysOfWeek, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDayOfWeek>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.DayOfWeekTypeConverter.ConvertFrom));
            }
            if (content.Contains("MaintenanceWindowHoursOfDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowHoursOfDay = (System.Collections.Generic.List<int>) content.GetValueForProperty("MaintenanceWindowHoursOfDay",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowHoursOfDay, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("MaintenanceWindowLeadTimeInWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowLeadTimeInWeek = (int?) content.GetValueForProperty("MaintenanceWindowLeadTimeInWeek",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowLeadTimeInWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaintenanceWindowCustomActionTimeoutInMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowCustomActionTimeoutInMin = (int?) content.GetValueForProperty("MaintenanceWindowCustomActionTimeoutInMin",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowCustomActionTimeoutInMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("MaintenanceWindowIsCustomActionTimeoutEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowIsCustomActionTimeoutEnabled = (bool?) content.GetValueForProperty("MaintenanceWindowIsCustomActionTimeoutEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowIsCustomActionTimeoutEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("MaintenanceWindowIsMonthlyPatchingEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowIsMonthlyPatchingEnabled = (bool?) content.GetValueForProperty("MaintenanceWindowIsMonthlyPatchingEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdatePropertiesInternal)this).MaintenanceWindowIsMonthlyPatchingEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.CloudExadataInfrastructureUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdateProperties DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new CloudExadataInfrastructureUpdateProperties(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.CloudExadataInfrastructureUpdateProperties"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdateProperties"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdateProperties DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new CloudExadataInfrastructureUpdateProperties(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="CloudExadataInfrastructureUpdateProperties" />, deserializing the content from a
        /// json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>
        /// an instance of the <see cref="CloudExadataInfrastructureUpdateProperties" /> model class.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.ICloudExadataInfrastructureUpdateProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.SerializationMode.IncludeAll)?.ToString();

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
    }
    /// The updatable properties of the CloudExadataInfrastructure.
    [System.ComponentModel.TypeConverter(typeof(CloudExadataInfrastructureUpdatePropertiesTypeConverter))]
    public partial interface ICloudExadataInfrastructureUpdateProperties

    {

    }
}