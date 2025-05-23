
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
Create an in-memory object for ShippingAddress.
.Description
Create an in-memory object for ShippingAddress.
.Example
New-AzDataBoxShippingAddressObject -StreetAddress1 "101 TOWNSEND ST" -StateOrProvince "CA" -Country "US" -City "San Francisco" -PostalCode "94107" -AddressType "Commercial"

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ShippingAddress
.Link
https://learn.microsoft.com/powershell/module/Az.DataBox/new-AzDataBoxShippingAddressObject
#>
function New-AzDataBoxShippingAddressObject {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DataBox.Models.Api20250201.ShippingAddress])]
[CmdletBinding(PositionalBinding=$false)]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Name of the Country.
    ${Country},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Street Address line 1.
    ${StreetAddress1},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.AddressType])]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Support.AddressType]
    # Type of address.
    ${AddressType},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Name of the City.
    ${City},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Name of the company.
    ${CompanyName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Postal code.
    ${PostalCode},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.Boolean]
    # Flag to indicate if customer has chosen to skip default address validation.
    ${SkipAddressValidation},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Name of the State or Province.
    ${StateOrProvince},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Street Address line 2.
    ${StreetAddress2},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Street Address line 3.
    ${StreetAddress3},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Tax Identification Number.
    ${TaxIdentificationNumber},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Category('Body')]
    [System.String]
    # Extended Zip Code.
    ${ZipExtendedCode}
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
            [Microsoft.Azure.PowerShell.Cmdlets.DataBox.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
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
            __AllParameterSets = 'Az.DataBox.custom\New-AzDataBoxShippingAddressObject';
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.DataBox.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
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
            [Microsoft.Azure.PowerShell.Cmdlets.DataBox.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
