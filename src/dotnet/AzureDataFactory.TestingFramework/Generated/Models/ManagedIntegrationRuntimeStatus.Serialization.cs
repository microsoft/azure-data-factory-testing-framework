// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    public partial class ManagedIntegrationRuntimeStatus
    {
        internal static ManagedIntegrationRuntimeStatus DeserializeManagedIntegrationRuntimeStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IntegrationRuntimeType type = default;
            Optional<string> dataFactoryName = default;
            Optional<IntegrationRuntimeState> state = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<IReadOnlyList<ManagedIntegrationRuntimeNode>> nodes = default;
            Optional<IReadOnlyList<ManagedIntegrationRuntimeError>> otherErrors = default;
            Optional<ManagedIntegrationRuntimeOperationResult> lastOperation = default;
            IReadOnlyDictionary<string, DataFactoryElement<string>> additionalProperties = default;
            Dictionary<string, DataFactoryElement<string>> additionalPropertiesDictionary = new Dictionary<string, DataFactoryElement<string>>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new IntegrationRuntimeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataFactoryName"u8))
                {
                    dataFactoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new IntegrationRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("nodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedIntegrationRuntimeNode> array = new List<ManagedIntegrationRuntimeNode>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedIntegrationRuntimeNode.DeserializeManagedIntegrationRuntimeNode(item));
                            }
                            nodes = array;
                            continue;
                        }
                        if (property0.NameEquals("otherErrors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedIntegrationRuntimeError> array = new List<ManagedIntegrationRuntimeError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedIntegrationRuntimeError.DeserializeManagedIntegrationRuntimeError(item));
                            }
                            otherErrors = array;
                            continue;
                        }
                        if (property0.NameEquals("lastOperation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastOperation = ManagedIntegrationRuntimeOperationResult.DeserializeManagedIntegrationRuntimeOperationResult(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ManagedIntegrationRuntimeStatus(type, dataFactoryName.Value, Optional.ToNullable(state), additionalProperties, Optional.ToNullable(createTime), Optional.ToList(nodes), Optional.ToList(otherErrors), lastOperation.Value);
        }
    }
}