// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> A copy activity Azure Table sink. </summary>
    public partial class AzureTableSink : CopySink
    {
        /// <summary> Initializes a new instance of AzureTableSink. </summary>
        public AzureTableSink()
        {
            CopySinkType = "AzureTableSink";
        }

        /// <summary> Initializes a new instance of AzureTableSink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="azureTableDefaultPartitionKeyValue"> Azure Table default partition key value. Type: string (or Expression with resultType string). </param>
        /// <param name="azureTablePartitionKeyName"> Azure Table partition key name. Type: string (or Expression with resultType string). </param>
        /// <param name="azureTableRowKeyName"> Azure Table row key name. Type: string (or Expression with resultType string). </param>
        /// <param name="azureTableInsertType"> Azure Table insert type. Type: string (or Expression with resultType string). </param>
        internal AzureTableSink(string copySinkType, DataFactoryElement<int> writeBatchSize, DataFactoryElement<string> writeBatchTimeout, DataFactoryElement<int> sinkRetryCount, DataFactoryElement<string> sinkRetryWait, DataFactoryElement<int> maxConcurrentConnections, DataFactoryElement<bool> disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> azureTableDefaultPartitionKeyValue, DataFactoryElement<string> azureTablePartitionKeyName, DataFactoryElement<string> azureTableRowKeyName, DataFactoryElement<string> azureTableInsertType) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            AzureTableDefaultPartitionKeyValue = azureTableDefaultPartitionKeyValue;
            AzureTablePartitionKeyName = azureTablePartitionKeyName;
            AzureTableRowKeyName = azureTableRowKeyName;
            AzureTableInsertType = azureTableInsertType;
            CopySinkType = copySinkType ?? "AzureTableSink";
        }

        /// <summary> Azure Table default partition key value. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureTableDefaultPartitionKeyValue { get; set; }
        /// <summary> Azure Table partition key name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureTablePartitionKeyName { get; set; }
        /// <summary> Azure Table row key name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureTableRowKeyName { get; set; }
        /// <summary> Azure Table insert type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureTableInsertType { get; set; }
    }
}