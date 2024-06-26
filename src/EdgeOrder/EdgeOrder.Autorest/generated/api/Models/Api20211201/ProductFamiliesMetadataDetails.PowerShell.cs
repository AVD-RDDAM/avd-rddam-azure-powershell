// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201
{
    using Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.PowerShell;

    /// <summary>Product families metadata details.</summary>
    [System.ComponentModel.TypeConverter(typeof(ProductFamiliesMetadataDetailsTypeConverter))]
    public partial class ProductFamiliesMetadataDetails
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
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductFamiliesMetadataDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetails DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ProductFamiliesMetadataDetails(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductFamiliesMetadataDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetails"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetails DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ProductFamiliesMetadataDetails(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ProductFamiliesMetadataDetails" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ProductFamiliesMetadataDetails" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetails FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductFamiliesMetadataDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ProductFamiliesMetadataDetails(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductFamilyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).Description = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescription) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).Description, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.DescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("CostInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICostInformation) content.GetValueForProperty("CostInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.CostInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AvailabilityInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation) content.GetValueForProperty("AvailabilityInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AvailabilityInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("HierarchyInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).HierarchyInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation) content.GetValueForProperty("HierarchyInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).HierarchyInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.HierarchyInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DescriptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionType = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType?) content.GetValueForProperty("DescriptionType",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionType, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType.CreateFrom);
            }
            if (content.Contains("DescriptionShortDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionShortDescription = (string) content.GetValueForProperty("DescriptionShortDescription",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionShortDescription, global::System.Convert.ToString);
            }
            if (content.Contains("DescriptionLongDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionLongDescription = (string) content.GetValueForProperty("DescriptionLongDescription",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionLongDescription, global::System.Convert.ToString);
            }
            if (content.Contains("DescriptionKeyword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionKeyword = (string[]) content.GetValueForProperty("DescriptionKeyword",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionKeyword, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DescriptionAttribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionAttribute = (string[]) content.GetValueForProperty("DescriptionAttribute",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionAttribute, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DescriptionLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionLink = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[]) content.GetValueForProperty("DescriptionLink",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionLink, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.LinkTypeConverter.ConvertFrom));
            }
            if (content.Contains("AvailabilityInformationAvailabilityStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationAvailabilityStage = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage?) content.GetValueForProperty("AvailabilityInformationAvailabilityStage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationAvailabilityStage, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage.CreateFrom);
            }
            if (content.Contains("AvailabilityInformationDisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationDisabledReason = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason?) content.GetValueForProperty("AvailabilityInformationDisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationDisabledReason, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason.CreateFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ImageInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ImageInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation[]) content.GetValueForProperty("ImageInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ImageInformation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ImageInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("FilterableProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).FilterableProperty = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty[]) content.GetValueForProperty("FilterableProperty",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).FilterableProperty, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.FilterablePropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProductLine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ProductLine = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine[]) content.GetValueForProperty("ProductLine",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ProductLine, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductLineTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceProviderDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ResourceProviderDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[]) content.GetValueForProperty("ResourceProviderDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ResourceProviderDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ResourceProviderDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CostInformationBillingMeterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformationBillingMeterDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails[]) content.GetValueForProperty("CostInformationBillingMeterDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformationBillingMeterDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.BillingMeterDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CostInformationBillingInfoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformationBillingInfoUrl = (string) content.GetValueForProperty("CostInformationBillingInfoUrl",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformationBillingInfoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityInformationDisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationDisabledReasonMessage = (string) content.GetValueForProperty("AvailabilityInformationDisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationDisabledReasonMessage, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductFamiliesMetadataDetails"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ProductFamiliesMetadataDetails(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamilyProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductFamilyPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).Description = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IDescription) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).Description, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.DescriptionTypeConverter.ConvertFrom);
            }
            if (content.Contains("CostInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ICostInformation) content.GetValueForProperty("CostInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.CostInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("AvailabilityInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IAvailabilityInformation) content.GetValueForProperty("AvailabilityInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.AvailabilityInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("HierarchyInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).HierarchyInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IHierarchyInformation) content.GetValueForProperty("HierarchyInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).HierarchyInformation, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.HierarchyInformationTypeConverter.ConvertFrom);
            }
            if (content.Contains("DescriptionType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionType = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType?) content.GetValueForProperty("DescriptionType",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionType, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DescriptionType.CreateFrom);
            }
            if (content.Contains("DescriptionShortDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionShortDescription = (string) content.GetValueForProperty("DescriptionShortDescription",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionShortDescription, global::System.Convert.ToString);
            }
            if (content.Contains("DescriptionLongDescription"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionLongDescription = (string) content.GetValueForProperty("DescriptionLongDescription",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionLongDescription, global::System.Convert.ToString);
            }
            if (content.Contains("DescriptionKeyword"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionKeyword = (string[]) content.GetValueForProperty("DescriptionKeyword",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionKeyword, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DescriptionAttribute"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionAttribute = (string[]) content.GetValueForProperty("DescriptionAttribute",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionAttribute, __y => TypeConverterExtensions.SelectToArray<string>(__y, global::System.Convert.ToString));
            }
            if (content.Contains("DescriptionLink"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionLink = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink[]) content.GetValueForProperty("DescriptionLink",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DescriptionLink, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ILink>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.LinkTypeConverter.ConvertFrom));
            }
            if (content.Contains("AvailabilityInformationAvailabilityStage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationAvailabilityStage = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage?) content.GetValueForProperty("AvailabilityInformationAvailabilityStage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationAvailabilityStage, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.AvailabilityStage.CreateFrom);
            }
            if (content.Contains("AvailabilityInformationDisabledReason"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationDisabledReason = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason?) content.GetValueForProperty("AvailabilityInformationDisabledReason",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationDisabledReason, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Support.DisabledReason.CreateFrom);
            }
            if (content.Contains("DisplayName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DisplayName = (string) content.GetValueForProperty("DisplayName",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).DisplayName, global::System.Convert.ToString);
            }
            if (content.Contains("ImageInformation"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ImageInformation = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation[]) content.GetValueForProperty("ImageInformation",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ImageInformation, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IImageInformation>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ImageInformationTypeConverter.ConvertFrom));
            }
            if (content.Contains("FilterableProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).FilterableProperty = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty[]) content.GetValueForProperty("FilterableProperty",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).FilterableProperty, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IFilterableProperty>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.FilterablePropertyTypeConverter.ConvertFrom));
            }
            if (content.Contains("ProductLine"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ProductLine = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine[]) content.GetValueForProperty("ProductLine",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ProductLine, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductLine>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ProductLineTypeConverter.ConvertFrom));
            }
            if (content.Contains("ResourceProviderDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ResourceProviderDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails[]) content.GetValueForProperty("ResourceProviderDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).ResourceProviderDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IResourceProviderDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.ResourceProviderDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CostInformationBillingMeterDetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformationBillingMeterDetail = (Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails[]) content.GetValueForProperty("CostInformationBillingMeterDetail",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformationBillingMeterDetail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IBillingMeterDetails>(__y, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.BillingMeterDetailsTypeConverter.ConvertFrom));
            }
            if (content.Contains("CostInformationBillingInfoUrl"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformationBillingInfoUrl = (string) content.GetValueForProperty("CostInformationBillingInfoUrl",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).CostInformationBillingInfoUrl, global::System.Convert.ToString);
            }
            if (content.Contains("AvailabilityInformationDisabledReasonMessage"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationDisabledReasonMessage = (string) content.GetValueForProperty("AvailabilityInformationDisabledReasonMessage",((Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Models.Api20211201.IProductFamiliesMetadataDetailsInternal)this).AvailabilityInformationDisabledReasonMessage, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.EdgeOrder.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Product families metadata details.
    [System.ComponentModel.TypeConverter(typeof(ProductFamiliesMetadataDetailsTypeConverter))]
    public partial interface IProductFamiliesMetadataDetails

    {

    }
}