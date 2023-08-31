// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A copy activity snowflake sink. </summary>
    public partial class SnowflakeSink : CopySink
    {
        /// <summary> Initializes a new instance of SnowflakeSink. </summary>
        public SnowflakeSink()
        {
            CopySinkType = "SnowflakeSink";
        }

        /// <summary> Initializes a new instance of SnowflakeSink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="preCopyScript"> SQL pre-copy script. Type: string (or Expression with resultType string). </param>
        /// <param name="importSettings"> Snowflake import settings. </param>
        internal SnowflakeSink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> preCopyScript, SnowflakeImportCopyCommand importSettings) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            PreCopyScript = preCopyScript;
            ImportSettings = importSettings;
            CopySinkType = copySinkType ?? "SnowflakeSink";
        }

        /// <summary> SQL pre-copy script. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PreCopyScript { get; set; }
        /// <summary> Snowflake import settings. </summary>
        public SnowflakeImportCopyCommand ImportSettings { get; set; }
    }
}
