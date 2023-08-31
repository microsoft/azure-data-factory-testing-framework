// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The data stored in JSON format. </summary>
    public partial class DatasetJsonFormat : DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of DatasetJsonFormat. </summary>
        public DatasetJsonFormat()
        {
            DatasetStorageFormatType = "JsonFormat";
        }

        /// <summary> Initializes a new instance of DatasetJsonFormat. </summary>
        /// <param name="datasetStorageFormatType"> Type of dataset storage format. </param>
        /// <param name="serializer"> Serializer. Type: string (or Expression with resultType string). </param>
        /// <param name="deserializer"> Deserializer. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="filePattern"> File pattern of JSON. To be more specific, the way of separating a collection of JSON objects. The default value is 'setOfObjects'. It is case-sensitive. </param>
        /// <param name="nestingSeparator"> The character used to separate nesting levels. Default value is '.' (dot). Type: string (or Expression with resultType string). </param>
        /// <param name="encodingName"> The code page name of the preferred encoding. If not provided, the default value is 'utf-8', unless the byte order mark (BOM) denotes another Unicode encoding. The full list of supported values can be found in the 'Name' column of the table of encodings in the following reference: https://go.microsoft.com/fwlink/?linkid=861078. Type: string (or Expression with resultType string). </param>
        /// <param name="jsonNodeReference"> The JSONPath of the JSON array element to be flattened. Example: "$.ArrayPath". Type: string (or Expression with resultType string). </param>
        /// <param name="jsonPathDefinition"> The JSONPath definition for each column mapping with a customized column name to extract data from JSON file. For fields under root object, start with "$"; for fields inside the array chosen by jsonNodeReference property, start from the array element. Example: {"Column1": "$.Column1Path", "Column2": "Column2PathInArray"}. Type: object (or Expression with resultType object). </param>
        internal DatasetJsonFormat(string datasetStorageFormatType, DataFactoryElement<string> serializer, DataFactoryElement<string> deserializer, IDictionary<string, DataFactoryElement<string>> additionalProperties, BinaryData filePattern, DataFactoryElement<string> nestingSeparator, DataFactoryElement<string> encodingName, DataFactoryElement<string> jsonNodeReference, BinaryData jsonPathDefinition) : base(datasetStorageFormatType, serializer, deserializer, additionalProperties)
        {
            FilePattern = filePattern;
            NestingSeparator = nestingSeparator;
            EncodingName = encodingName;
            JsonNodeReference = jsonNodeReference;
            JsonPathDefinition = jsonPathDefinition;
            DatasetStorageFormatType = datasetStorageFormatType ?? "JsonFormat";
        }

        /// <summary>
        /// File pattern of JSON. To be more specific, the way of separating a collection of JSON objects. The default value is 'setOfObjects'. It is case-sensitive.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData FilePattern { get; set; }
        /// <summary> The character used to separate nesting levels. Default value is '.' (dot). Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> NestingSeparator { get; set; }
        /// <summary> The code page name of the preferred encoding. If not provided, the default value is 'utf-8', unless the byte order mark (BOM) denotes another Unicode encoding. The full list of supported values can be found in the 'Name' column of the table of encodings in the following reference: https://go.microsoft.com/fwlink/?linkid=861078. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> EncodingName { get; set; }
        /// <summary> The JSONPath of the JSON array element to be flattened. Example: "$.ArrayPath". Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> JsonNodeReference { get; set; }
        /// <summary>
        /// The JSONPath definition for each column mapping with a customized column name to extract data from JSON file. For fields under root object, start with "$"; for fields inside the array chosen by jsonNodeReference property, start from the array element. Example: {"Column1": "$.Column1Path", "Column2": "Column2PathInArray"}. Type: object (or Expression with resultType object).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData JsonPathDefinition { get; set; }
    }
}
