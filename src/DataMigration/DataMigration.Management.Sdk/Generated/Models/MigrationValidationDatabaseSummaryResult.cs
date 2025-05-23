// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using System.Linq;

    /// <summary>
    /// Migration Validation Database level summary result
    /// </summary>
    public partial class MigrationValidationDatabaseSummaryResult
    {
        /// <summary>
        /// Initializes a new instance of the MigrationValidationDatabaseSummaryResult class.
        /// </summary>
        public MigrationValidationDatabaseSummaryResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MigrationValidationDatabaseSummaryResult class.
        /// </summary>

        /// <param name="id">Result identifier
        /// </param>

        /// <param name="migrationId">Migration Identifier
        /// </param>

        /// <param name="sourceDatabaseName">Name of the source database
        /// </param>

        /// <param name="targetDatabaseName">Name of the target database
        /// </param>

        /// <param name="startedOn">Validation start time
        /// </param>

        /// <param name="endedOn">Validation end time
        /// </param>

        /// <param name="status">Current status of validation at the database level
        /// Possible values include: &#39;Default&#39;, &#39;NotStarted&#39;, &#39;Initialized&#39;,
        /// &#39;InProgress&#39;, &#39;Completed&#39;, &#39;CompletedWithIssues&#39;, &#39;Stopped&#39;, &#39;Failed&#39;</param>
        public MigrationValidationDatabaseSummaryResult(string id = default(string), string migrationId = default(string), string sourceDatabaseName = default(string), string targetDatabaseName = default(string), System.DateTimeOffset? startedOn = default(System.DateTimeOffset?), System.DateTimeOffset? endedOn = default(System.DateTimeOffset?), string status = default(string))

        {
            this.Id = id;
            this.MigrationId = migrationId;
            this.SourceDatabaseName = sourceDatabaseName;
            this.TargetDatabaseName = targetDatabaseName;
            this.StartedOn = startedOn;
            this.EndedOn = endedOn;
            this.Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets result identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id {get; private set; }

        /// <summary>
        /// Gets migration Identifier
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "migrationId")]
        public string MigrationId {get; private set; }

        /// <summary>
        /// Gets name of the source database
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceDatabaseName")]
        public string SourceDatabaseName {get; private set; }

        /// <summary>
        /// Gets name of the target database
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "targetDatabaseName")]
        public string TargetDatabaseName {get; private set; }

        /// <summary>
        /// Gets validation start time
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startedOn")]
        public System.DateTimeOffset? StartedOn {get; private set; }

        /// <summary>
        /// Gets validation end time
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endedOn")]
        public System.DateTimeOffset? EndedOn {get; private set; }

        /// <summary>
        /// Gets current status of validation at the database level Possible values include: &#39;Default&#39;, &#39;NotStarted&#39;, &#39;Initialized&#39;, &#39;InProgress&#39;, &#39;Completed&#39;, &#39;CompletedWithIssues&#39;, &#39;Stopped&#39;, &#39;Failed&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "status")]
        public string Status {get; private set; }
    }
}