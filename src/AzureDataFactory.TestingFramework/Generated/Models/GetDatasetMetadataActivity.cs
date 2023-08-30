// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Activity to get metadata of dataset. </summary>
    public partial class GetDatasetMetadataActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of GetDatasetMetadataActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="dataset"> GetMetadata activity dataset reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataset"/> is null. </exception>
        public GetDatasetMetadataActivity(string name, DatasetReference dataset) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(dataset, nameof(dataset));

            Dataset = dataset;
            FieldList = new ChangeTrackingList<BinaryData>();
            ActivityType = "GetMetadata";
        }

        /// <summary> Initializes a new instance of GetDatasetMetadataActivity. </summary>
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
        /// <param name="dataset"> GetMetadata activity dataset reference. </param>
        /// <param name="fieldList"> Fields of metadata to get from dataset. </param>
        /// <param name="storeSettings">
        /// GetMetadata activity store settings.
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleReadSettings"/>, <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/>, <see cref="OracleCloudStorageReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </param>
        /// <param name="formatSettings">
        /// GetMetadata activity format settings.
        /// Please note <see cref="FormatReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BinaryReadSettings"/>, <see cref="JsonReadSettings"/>, <see cref="XmlReadSettings"/> and <see cref="DelimitedTextReadSettings"/>.
        /// </param>
        internal GetDatasetMetadataActivity(string name, string activityType, string description, PipelineActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<PipelineActivityDependency> dependsOn, IList<PipelineActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, DataFactoryLinkedServiceReference linkedServiceName, PipelineActivityPolicy policy, DatasetReference dataset, IList<BinaryData> fieldList, StoreReadSettings storeSettings, FormatReadSettings formatSettings) : base(name, activityType, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Dataset = dataset;
            FieldList = fieldList;
            StoreSettings = storeSettings;
            FormatSettings = formatSettings;
            ActivityType = activityType ?? "GetMetadata";
        }

        /// <summary> GetMetadata activity dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary>
        /// Fields of metadata to get from dataset.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> FieldList { get; }
        /// <summary>
        /// GetMetadata activity store settings.
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleReadSettings"/>, <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/>, <see cref="OracleCloudStorageReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </summary>
        public StoreReadSettings StoreSettings { get; set; }
        /// <summary>
        /// GetMetadata activity format settings.
        /// Please note <see cref="FormatReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BinaryReadSettings"/>, <see cref="JsonReadSettings"/>, <see cref="XmlReadSettings"/> and <see cref="DelimitedTextReadSettings"/>.
        /// </summary>
        public FormatReadSettings FormatSettings { get; set; }
    }
}