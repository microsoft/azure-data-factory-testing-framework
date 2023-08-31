// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class ParquetWriteSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxRowsPerFile))
            {
                writer.WritePropertyName("maxRowsPerFile"u8);
                JsonSerializer.Serialize(writer, MaxRowsPerFile);
            }
            if (Optional.IsDefined(FileNamePrefix))
            {
                writer.WritePropertyName("fileNamePrefix"u8);
                JsonSerializer.Serialize(writer, FileNamePrefix);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FormatWriteSettingsType);
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(item.Value.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ParquetWriteSettings DeserializeParquetWriteSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<int>> maxRowsPerFile = default;
            Optional<DataFactoryElement<string>> fileNamePrefix = default;
            string type = default;
            IDictionary<string, DataFactoryElement<string>> additionalProperties = default;
            Dictionary<string, DataFactoryElement<string>> additionalPropertiesDictionary = new Dictionary<string, DataFactoryElement<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxRowsPerFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxRowsPerFile = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("fileNamePrefix"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileNamePrefix = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ParquetWriteSettings(type, additionalProperties, maxRowsPerFile.Value, fileNamePrefix.Value);
        }
    }
}
