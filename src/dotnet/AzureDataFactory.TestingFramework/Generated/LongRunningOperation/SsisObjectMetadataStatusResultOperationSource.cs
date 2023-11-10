// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using AzureDataFactory.TestingFramework.Models;

namespace Azure.ResourceManager.DataFactory
{
    internal class SsisObjectMetadataStatusResultOperationSource : IOperationSource<SsisObjectMetadataStatusResult>
    {
        SsisObjectMetadataStatusResult IOperationSource<SsisObjectMetadataStatusResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return SsisObjectMetadataStatusResult.DeserializeSsisObjectMetadataStatusResult(document.RootElement);
        }

        async ValueTask<SsisObjectMetadataStatusResult> IOperationSource<SsisObjectMetadataStatusResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return SsisObjectMetadataStatusResult.DeserializeSsisObjectMetadataStatusResult(document.RootElement);
        }
    }
}