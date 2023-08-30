// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Managed integration runtime, including managed elastic and managed dedicated integration runtimes. </summary>
    public partial class ManagedIntegrationRuntime : DataFactoryIntegrationRuntimeProperties
    {
        /// <summary> Initializes a new instance of ManagedIntegrationRuntime. </summary>
        public ManagedIntegrationRuntime()
        {
            IntegrationRuntimeType = IntegrationRuntimeType.Managed;
        }

        /// <summary> Initializes a new instance of ManagedIntegrationRuntime. </summary>
        /// <param name="integrationRuntimeType"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="state"> Integration runtime state, only valid for managed dedicated integration runtime. </param>
        /// <param name="managedVirtualNetwork"> Managed Virtual Network reference. </param>
        /// <param name="computeProperties"> The compute resource for managed integration runtime. </param>
        /// <param name="ssisProperties"> SSIS properties for managed integration runtime. </param>
        /// <param name="customerVirtualNetwork"> The name of virtual network to which Azure-SSIS integration runtime will join. </param>
        internal ManagedIntegrationRuntime(IntegrationRuntimeType integrationRuntimeType, string description, IDictionary<string, BinaryData> additionalProperties, IntegrationRuntimeState? state, ManagedVirtualNetworkReference managedVirtualNetwork, IntegrationRuntimeComputeProperties computeProperties, IntegrationRuntimeSsisProperties ssisProperties, IntegrationRuntimeCustomerVirtualNetwork customerVirtualNetwork) : base(integrationRuntimeType, description, additionalProperties)
        {
            State = state;
            ManagedVirtualNetwork = managedVirtualNetwork;
            ComputeProperties = computeProperties;
            SsisProperties = ssisProperties;
            CustomerVirtualNetwork = customerVirtualNetwork;
            IntegrationRuntimeType = integrationRuntimeType;
        }

        /// <summary> Integration runtime state, only valid for managed dedicated integration runtime. </summary>
        public IntegrationRuntimeState? State { get; }
        /// <summary> Managed Virtual Network reference. </summary>
        public ManagedVirtualNetworkReference ManagedVirtualNetwork { get; set; }
        /// <summary> The compute resource for managed integration runtime. </summary>
        public IntegrationRuntimeComputeProperties ComputeProperties { get; set; }
        /// <summary> SSIS properties for managed integration runtime. </summary>
        public IntegrationRuntimeSsisProperties SsisProperties { get; set; }
        /// <summary> The name of virtual network to which Azure-SSIS integration runtime will join. </summary>
        internal IntegrationRuntimeCustomerVirtualNetwork CustomerVirtualNetwork { get; set; }
        /// <summary> The ID of subnet to which Azure-SSIS integration runtime will join. </summary>
        public ResourceIdentifier CustomerVirtualNetworkSubnetId
        {
            get => CustomerVirtualNetwork is null ? default : CustomerVirtualNetwork.SubnetId;
            set
            {
                if (CustomerVirtualNetwork is null)
                    CustomerVirtualNetwork = new IntegrationRuntimeCustomerVirtualNetwork();
                CustomerVirtualNetwork.SubnetId = value;
            }
        }
    }
}