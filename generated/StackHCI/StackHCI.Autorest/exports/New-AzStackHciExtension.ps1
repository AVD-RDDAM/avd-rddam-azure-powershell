
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
Create Extension for HCI cluster.
.Description
Create Extension for HCI cluster.
.Example
New-AzStackHciExtension -ArcSettingName "default" -ClusterName "myCluster" -Name "MicrosoftMonitoringAgent" -ResourceGroupName test-rg
.Example
$Settings = @{ "commandToExecute" = "powershell.exe -c Get-Process" }
New-AzStackHciExtension -ArcSettingName "default" -ClusterName "myCluster" -Name "MicrosoftMonitoringAgent" -ResourceGroupName test-rg -ExtensionParameterPublisher "Microsoft.Compute" -ExtensionParameterType "MicrosoftMonitoringAgent" -ExtensionParameterProtectedSetting $Settings

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtension
.Link
https://learn.microsoft.com/powershell/module/az.stackhci/new-azstackhciextension
#>
function New-AzStackHciExtension {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtension])]
[CmdletBinding(DefaultParameterSetName='CreateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Path')]
    [System.String]
    # The name of the proxy resource holding details of HCI ArcSetting information.
    ${ArcSettingName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Path')]
    [System.String]
    # The name of the cluster.
    ${ClusterName},

    [Parameter(Mandatory)]
    [Alias('ExtensionName')]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Path')]
    [System.String]
    # The name of the machine extension.
    ${Name},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    # The value must be an UUID.
    ${SubscriptionId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether the extension should use a newer minor version if one is available at deployment time.
    # Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
    ${ExtensionParameterAutoUpgradeMinorVersion},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Indicates whether the extension should be automatically upgraded by the platform if there is a newer version available.
    ${ExtensionParameterEnableAutomaticUpgrade},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Body')]
    [System.String]
    # How the extension handler should be forced to update even if the extension configuration has not changed.
    ${ExtensionParameterForceUpdateTag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionParametersProtectedSettings]))]
    [System.Collections.Hashtable]
    # Protected settings (may contain secrets).
    ${ExtensionParameterProtectedSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Body')]
    [System.String]
    # The name of the extension handler publisher.
    ${ExtensionParameterPublisher},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20240401.IExtensionParametersSettings]))]
    [System.Collections.Hashtable]
    # Json formatted public settings for the extension.
    ${ExtensionParameterSetting},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Body')]
    [System.String]
    # Specifies the type of the extension; an example is "CustomScriptExtension".
    ${ExtensionParameterType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Body')]
    [System.String]
    # Specifies the version of the script handler.
    # Latest version would be used if not specified.
    ${ExtensionParameterTypeHandlerVersion},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            CreateExpanded = 'Az.StackHCI.private\New-AzStackHciExtension_CreateExpanded';
        }
        if (('CreateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
