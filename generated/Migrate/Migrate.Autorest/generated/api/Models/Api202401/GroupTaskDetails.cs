// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>
    /// This class represents the group task details when parent child relationship exists in the drill down.
    /// </summary>
    public partial class GroupTaskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGroupTaskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IGroupTaskDetailsInternal
    {

        /// <summary>Backing field for <see cref="ChildTask" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IAsrTask[] _childTask;

        /// <summary>The child tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IAsrTask[] ChildTask { get => this._childTask; set => this._childTask = value; }

        /// <summary>Backing field for <see cref="InstanceType" /> property.</summary>
        private string _instanceType;

        /// <summary>The type of task details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string InstanceType { get => this._instanceType; set => this._instanceType = value; }

        /// <summary>Creates an new <see cref="GroupTaskDetails" /> instance.</summary>
        public GroupTaskDetails()
        {

        }
    }
    /// This class represents the group task details when parent child relationship exists in the drill down.
    public partial interface IGroupTaskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The child tasks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The child tasks.",
        SerializedName = @"childTasks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IAsrTask) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IAsrTask[] ChildTask { get; set; }
        /// <summary>The type of task details.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The type of task details.",
        SerializedName = @"instanceType",
        PossibleTypes = new [] { typeof(string) })]
        string InstanceType { get; set; }

    }
    /// This class represents the group task details when parent child relationship exists in the drill down.
    internal partial interface IGroupTaskDetailsInternal

    {
        /// <summary>The child tasks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202401.IAsrTask[] ChildTask { get; set; }
        /// <summary>The type of task details.</summary>
        string InstanceType { get; set; }

    }
}