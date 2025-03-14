// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>Instance view status.</summary>
    public partial class InstanceViewStatus :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IInstanceViewStatus,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.IInstanceViewStatusInternal
    {

        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>The status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string Code { get => this._code; set => this._code = value; }

        /// <summary>Backing field for <see cref="DisplayStatus" /> property.</summary>
        private string _displayStatus;

        /// <summary>The short localizable label for the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string DisplayStatus { get => this._displayStatus; set => this._displayStatus = value; }

        /// <summary>Backing field for <see cref="Level" /> property.</summary>
        private string _level;

        /// <summary>The level code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string Level { get => this._level; set => this._level = value; }

        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>The detailed status message, including for alerts and error messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public string Message { get => this._message; set => this._message = value; }

        /// <summary>Backing field for <see cref="Time" /> property.</summary>
        private global::System.DateTime? _time;

        /// <summary>The time of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PropertyOrigin.Owned)]
        public global::System.DateTime? Time { get => this._time; set => this._time = value; }

        /// <summary>Creates an new <see cref="InstanceViewStatus" /> instance.</summary>
        public InstanceViewStatus()
        {

        }
    }
    /// Instance view status.
    public partial interface IInstanceViewStatus :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.IJsonSerializable
    {
        /// <summary>The status code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The status code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get; set; }
        /// <summary>The short localizable label for the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The short localizable label for the status.",
        SerializedName = @"displayStatus",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayStatus { get; set; }
        /// <summary>The level code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The level code.",
        SerializedName = @"level",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PSArgumentCompleterAttribute("Info", "Warning", "Error")]
        string Level { get; set; }
        /// <summary>The detailed status message, including for alerts and error messages.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The detailed status message, including for alerts and error messages.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get; set; }
        /// <summary>The time of the status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The time of the status.",
        SerializedName = @"time",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? Time { get; set; }

    }
    /// Instance view status.
    internal partial interface IInstanceViewStatusInternal

    {
        /// <summary>The status code.</summary>
        string Code { get; set; }
        /// <summary>The short localizable label for the status.</summary>
        string DisplayStatus { get; set; }
        /// <summary>The level code.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.PSArgumentCompleterAttribute("Info", "Warning", "Error")]
        string Level { get; set; }
        /// <summary>The detailed status message, including for alerts and error messages.</summary>
        string Message { get; set; }
        /// <summary>The time of the status.</summary>
        global::System.DateTime? Time { get; set; }

    }
}