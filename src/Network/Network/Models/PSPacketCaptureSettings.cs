﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Network.Models
{
    using Microsoft.WindowsAzure.Commands.Common.Attributes;
    using Newtonsoft.Json;

    public class PSPacketCaptureSettings 
    {
        /// <summary>
        /// Gets or sets number of file count.
        /// </summary>
        [JsonProperty(Order = 1)]
        [Ps1Xml(Target = ViewControl.Table)]
        public int? FileCount { get; set; }

        /// <summary>
        /// Gets or sets number of bytes captured per packet.
        /// </summary>
        [JsonProperty(Order = 2)]
        [Ps1Xml(Target = ViewControl.Table)]
        public long? FileSizeInBytes { get; set; }

        /// <summary>
        /// Gets or sets maximum duration of the capture session in seconds.
        /// </summary>
        [JsonProperty(Order = 3)]
        [Ps1Xml(Target = ViewControl.Table)]
        public int? SessionTimeLimitInSeconds { get; set; }
    }
}
