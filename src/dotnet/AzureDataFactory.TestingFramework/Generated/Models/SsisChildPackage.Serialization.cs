// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class SsisChildPackage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("packagePath"u8);
            JsonSerializer.Serialize(writer, PackagePath);
            if (Optional.IsDefined(PackageName))
            {
                writer.WritePropertyName("packageName"u8);
                writer.WriteStringValue(PackageName);
            }
            writer.WritePropertyName("packageContent"u8);
            JsonSerializer.Serialize(writer, PackageContent);
            if (Optional.IsDefined(PackageLastModifiedDate))
            {
                writer.WritePropertyName("packageLastModifiedDate"u8);
                writer.WriteStringValue(PackageLastModifiedDate);
            }
            writer.WriteEndObject();
        }

        internal static SsisChildPackage DeserializeSsisChildPackage(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFactoryElement<string> packagePath = default;
            Optional<string> packageName = default;
            DataFactoryElement<string> packageContent = default;
            Optional<string> packageLastModifiedDate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("packagePath"u8))
                {
                    packagePath = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("packageName"u8))
                {
                    packageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("packageContent"u8))
                {
                    packageContent = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("packageLastModifiedDate"u8))
                {
                    packageLastModifiedDate = property.Value.GetString();
                    continue;
                }
            }
            return new SsisChildPackage(packagePath, packageName.Value, packageContent, packageLastModifiedDate.Value);
        }
    }
}