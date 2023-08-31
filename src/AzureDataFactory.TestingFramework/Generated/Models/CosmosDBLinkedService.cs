// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Microsoft Azure Cosmos Database (CosmosDB) linked service. </summary>
    public partial class CosmosDBLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of CosmosDBLinkedService. </summary>
        public CosmosDBLinkedService()
        {
            LinkedServiceType = "CosmosDb";
        }

        /// <summary> Initializes a new instance of CosmosDBLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="accountEndpoint"> The endpoint of the Azure CosmosDB account. Type: string (or Expression with resultType string). </param>
        /// <param name="database"> The name of the database. Type: string (or Expression with resultType string). </param>
        /// <param name="accountKey"> The account key of the Azure CosmosDB account. Type: SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="servicePrincipalId"> The client ID of the application in Azure Active Directory used for Server-To-Server authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="servicePrincipalCredentialType"> The service principal credential type to use in Server-To-Server authentication. 'ServicePrincipalKey' for key/secret, 'ServicePrincipalCert' for certificate. Type: string. </param>
        /// <param name="servicePrincipalCredential"> The credential of the service principal object in Azure Active Directory. If servicePrincipalCredentialType is 'ServicePrincipalKey', servicePrincipalCredential can be SecureString or AzureKeyVaultSecretReference. If servicePrincipalCredentialType is 'ServicePrincipalCert', servicePrincipalCredential can only be AzureKeyVaultSecretReference. </param>
        /// <param name="tenant"> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </param>
        /// <param name="azureCloudType"> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </param>
        /// <param name="connectionMode"> The connection mode used to access CosmosDB account. Type: string. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal CosmosDBLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> connectionString, DataFactoryElement<string> accountEndpoint, DataFactoryElement<string> database, DataFactorySecretBaseDefinition accountKey, DataFactoryElement<string> servicePrincipalId, DataFactoryElement<string> servicePrincipalCredentialType, DataFactorySecretBaseDefinition servicePrincipalCredential, DataFactoryElement<string> tenant, DataFactoryElement<string> azureCloudType, CosmosDBConnectionMode? connectionMode, string encryptedCredential, DataFactoryCredentialReference credential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            AccountEndpoint = accountEndpoint;
            Database = database;
            AccountKey = accountKey;
            ServicePrincipalId = servicePrincipalId;
            ServicePrincipalCredentialType = servicePrincipalCredentialType;
            ServicePrincipalCredential = servicePrincipalCredential;
            Tenant = tenant;
            AzureCloudType = azureCloudType;
            ConnectionMode = connectionMode;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            LinkedServiceType = linkedServiceType ?? "CosmosDb";
        }

        /// <summary> The connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> The endpoint of the Azure CosmosDB account. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AccountEndpoint { get; set; }
        /// <summary> The name of the database. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Database { get; set; }
        /// <summary> The account key of the Azure CosmosDB account. Type: SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactorySecretBaseDefinition AccountKey { get; set; }
        /// <summary> The client ID of the application in Azure Active Directory used for Server-To-Server authentication. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> ServicePrincipalId { get; set; }
        /// <summary> The service principal credential type to use in Server-To-Server authentication. 'ServicePrincipalKey' for key/secret, 'ServicePrincipalCert' for certificate. Type: string. </summary>
        public DataFactoryElement<string> ServicePrincipalCredentialType { get; set; }
        /// <summary> The credential of the service principal object in Azure Active Directory. If servicePrincipalCredentialType is 'ServicePrincipalKey', servicePrincipalCredential can be SecureString or AzureKeyVaultSecretReference. If servicePrincipalCredentialType is 'ServicePrincipalCert', servicePrincipalCredential can only be AzureKeyVaultSecretReference. </summary>
        public DataFactorySecretBaseDefinition ServicePrincipalCredential { get; set; }
        /// <summary> The name or ID of the tenant to which the service principal belongs. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Tenant { get; set; }
        /// <summary> Indicates the azure cloud type of the service principle auth. Allowed values are AzurePublic, AzureChina, AzureUsGovernment, AzureGermany. Default value is the data factory regions’ cloud type. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AzureCloudType { get; set; }
        /// <summary> The connection mode used to access CosmosDB account. Type: string. </summary>
        public CosmosDBConnectionMode? ConnectionMode { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
    }
}
