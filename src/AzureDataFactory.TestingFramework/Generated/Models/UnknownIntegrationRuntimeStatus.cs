// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The UnknownIntegrationRuntimeStatus. </summary>
    internal partial class UnknownIntegrationRuntimeStatus : IntegrationRuntimeStatus
    {
        /// <summary> Initializes a new instance of UnknownIntegrationRuntimeStatus. </summary>
        /// <param name="runtimeType"> Type of integration runtime. </param>
        /// <param name="dataFactoryName"> The data factory name which the integration runtime belong to. </param>
        /// <param name="state"> The state of integration runtime. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownIntegrationRuntimeStatus(IntegrationRuntimeType runtimeType, string dataFactoryName, IntegrationRuntimeState? state, IReadOnlyDictionary<string, BinaryData> additionalProperties) : base(runtimeType, dataFactoryName, state, additionalProperties)
        {
            RuntimeType = runtimeType;
        }
    }
}