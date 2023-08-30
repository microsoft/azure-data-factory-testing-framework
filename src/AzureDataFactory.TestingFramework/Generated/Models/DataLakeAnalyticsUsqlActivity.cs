// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Data Lake Analytics U-SQL activity. </summary>
    public partial class DataLakeAnalyticsUsqlActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsUsqlActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="scriptPath"> Case-sensitive path to folder that contains the U-SQL script. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptLinkedService"> Script linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="scriptPath"/> or <paramref name="scriptLinkedService"/> is null. </exception>
        public DataLakeAnalyticsUsqlActivity(string name, DataFactoryElement<string> scriptPath, DataFactoryLinkedServiceReference scriptLinkedService) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(scriptPath, nameof(scriptPath));
            Argument.AssertNotNull(scriptLinkedService, nameof(scriptLinkedService));

            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            Parameters = new ChangeTrackingDictionary<string, BinaryData>();
            ActivityType = "DataLakeAnalyticsU-SQL";
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsUsqlActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="scriptPath"> Case-sensitive path to folder that contains the U-SQL script. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptLinkedService"> Script linked service reference. </param>
        /// <param name="degreeOfParallelism"> The maximum number of nodes simultaneously used to run the job. Default value is 1. Type: integer (or Expression with resultType integer), minimum: 1. </param>
        /// <param name="priority"> Determines which jobs out of all that are queued should be selected to run first. The lower the number, the higher the priority. Default value is 1000. Type: integer (or Expression with resultType integer), minimum: 1. </param>
        /// <param name="parameters"> Parameters for U-SQL job request. </param>
        /// <param name="runtimeVersion"> Runtime version of the U-SQL engine to use. Type: string (or Expression with resultType string). </param>
        /// <param name="compilationMode"> Compilation mode of U-SQL. Must be one of these values : Semantic, Full and SingleBox. Type: string (or Expression with resultType string). </param>
        internal DataLakeAnalyticsUsqlActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DataFactoryElement<string> scriptPath, DataFactoryLinkedServiceReference scriptLinkedService, DataFactoryElement<int> degreeOfParallelism, DataFactoryElement<int> priority, IDictionary<string, BinaryData> parameters, DataFactoryElement<string> runtimeVersion, DataFactoryElement<string> compilationMode) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            ScriptPath = scriptPath;
            ScriptLinkedService = scriptLinkedService;
            DegreeOfParallelism = degreeOfParallelism;
            Priority = priority;
            Parameters = parameters;
            RuntimeVersion = runtimeVersion;
            CompilationMode = compilationMode;
            ActivityType = activityType ?? "DataLakeAnalyticsU-SQL";
        }

        /// <summary> Case-sensitive path to folder that contains the U-SQL script. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ScriptPath { get; set; }
        /// <summary> Script linked service reference. </summary>
        public DataFactoryLinkedServiceReference ScriptLinkedService { get; set; }
        /// <summary> The maximum number of nodes simultaneously used to run the job. Default value is 1. Type: integer (or Expression with resultType integer), minimum: 1. </summary>
        public DataFactoryElement<int> DegreeOfParallelism { get; set; }
        /// <summary> Determines which jobs out of all that are queued should be selected to run first. The lower the number, the higher the priority. Default value is 1000. Type: integer (or Expression with resultType integer), minimum: 1. </summary>
        public DataFactoryElement<int> Priority { get; set; }
        /// <summary>
        /// Parameters for U-SQL job request.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IDictionary<string, BinaryData> Parameters { get; }
        /// <summary> Runtime version of the U-SQL engine to use. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> RuntimeVersion { get; set; }
        /// <summary> Compilation mode of U-SQL. Must be one of these values : Semantic, Full and SingleBox. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> CompilationMode { get; set; }
    }
}