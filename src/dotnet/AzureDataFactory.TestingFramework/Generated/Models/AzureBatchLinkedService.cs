// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Azure Batch linked service. </summary>
    public partial class AzureBatchLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of AzureBatchLinkedService. </summary>
        /// <param name="accountName"> The Azure Batch account name. Type: string (or Expression with resultType string). </param>
        /// <param name="batchUri"> The Azure Batch URI. Type: string (or Expression with resultType string). </param>
        /// <param name="poolName"> The Azure Batch pool name. Type: string (or Expression with resultType string). </param>
        /// <param name="linkedServiceName"> The Azure Storage linked service reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="batchUri"/>, <paramref name="poolName"/> or <paramref name="linkedServiceName"/> is null. </exception>
        public AzureBatchLinkedService(DataFactoryElement<string> accountName, DataFactoryElement<string> batchUri, DataFactoryElement<string> poolName, DataFactoryLinkedServiceReference linkedServiceName)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(batchUri, nameof(batchUri));
            Argument.AssertNotNull(poolName, nameof(poolName));
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));

            AccountName = accountName;
            BatchUri = batchUri;
            PoolName = poolName;
            LinkedServiceName = linkedServiceName;
            LinkedServiceType = "AzureBatch";
        }

        /// <summary> Initializes a new instance of AzureBatchLinkedService. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="accountName"> The Azure Batch account name. Type: string (or Expression with resultType string). </param>
        /// <param name="accessKey"> The Azure Batch account access key. </param>
        /// <param name="batchUri"> The Azure Batch URI. Type: string (or Expression with resultType string). </param>
        /// <param name="poolName"> The Azure Batch pool name. Type: string (or Expression with resultType string). </param>
        /// <param name="linkedServiceName"> The Azure Storage linked service reference. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal AzureBatchLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, DataFactoryElement<string>> additionalProperties, DataFactoryElement<string> accountName, DataFactorySecretBaseDefinition accessKey, DataFactoryElement<string> batchUri, DataFactoryElement<string> poolName, DataFactoryLinkedServiceReference linkedServiceName, string encryptedCredential, DataFactoryCredentialReference credential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            AccountName = accountName;
            AccessKey = accessKey;
            BatchUri = batchUri;
            PoolName = poolName;
            LinkedServiceName = linkedServiceName;
            EncryptedCredential = encryptedCredential;
            Credential = credential;
            LinkedServiceType = linkedServiceType ?? "AzureBatch";
        }

        /// <summary> The Azure Batch account name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> AccountName { get; set; }
        /// <summary> The Azure Batch account access key. </summary>
        public DataFactorySecretBaseDefinition AccessKey { get; set; }
        /// <summary> The Azure Batch URI. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> BatchUri { get; set; }
        /// <summary> The Azure Batch pool name. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> PoolName { get; set; }
        /// <summary> The Azure Storage linked service reference. </summary>
        public DataFactoryLinkedServiceReference LinkedServiceName { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public DataFactoryCredentialReference Credential { get; set; }
    }
}