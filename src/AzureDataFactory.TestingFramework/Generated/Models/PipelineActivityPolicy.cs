// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Execution policy for an activity. </summary>
    public partial class PipelineActivityPolicy
    {
        /// <summary> Initializes a new instance of PipelineActivityPolicy. </summary>
        public PipelineActivityPolicy()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of PipelineActivityPolicy. </summary>
        /// <param name="timeout"> Specifies the timeout for the activity to run. The default timeout is 7 days. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="retry"> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="retryIntervalInSeconds"> Interval between each retry attempt (in seconds). The default is 30 sec. </param>
        /// <param name="isSecureInputEnabled"> When set to true, Input from activity is considered as secure and will not be logged to monitoring. </param>
        /// <param name="isSecureOutputEnabled"> When set to true, Output from activity is considered as secure and will not be logged to monitoring. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PipelineActivityPolicy(DataFactoryElement<string> timeout, DataFactoryElement<int> retry, int? retryIntervalInSeconds, bool? isSecureInputEnabled, bool? isSecureOutputEnabled, IDictionary<string, BinaryData> additionalProperties)
        {
            Timeout = timeout;
            Retry = retry;
            RetryIntervalInSeconds = retryIntervalInSeconds;
            IsSecureInputEnabled = isSecureInputEnabled;
            IsSecureOutputEnabled = isSecureOutputEnabled;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Specifies the timeout for the activity to run. The default timeout is 7 days. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </summary>
        public DataFactoryElement<string> Timeout { get; set; }
        /// <summary> Maximum ordinary retry attempts. Default is 0. Type: integer (or Expression with resultType integer), minimum: 0. </summary>
        public DataFactoryElement<int> Retry { get; set; }
        /// <summary> Interval between each retry attempt (in seconds). The default is 30 sec. </summary>
        public int? RetryIntervalInSeconds { get; set; }
        /// <summary> When set to true, Input from activity is considered as secure and will not be logged to monitoring. </summary>
        public bool? IsSecureInputEnabled { get; set; }
        /// <summary> When set to true, Output from activity is considered as secure and will not be logged to monitoring. </summary>
        public bool? IsSecureOutputEnabled { get; set; }
        /// <summary>
        /// Additional Properties
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
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}