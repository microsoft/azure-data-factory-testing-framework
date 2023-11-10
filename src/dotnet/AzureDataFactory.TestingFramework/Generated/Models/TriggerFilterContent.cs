// <auto-generated/>

#nullable disable

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Query parameters for triggers. </summary>
    public partial class TriggerFilterContent
    {
        /// <summary> Initializes a new instance of TriggerFilterContent. </summary>
        public TriggerFilterContent()
        {
        }

        /// <summary> The continuation token for getting the next page of results. Null for first page. </summary>
        public string ContinuationToken { get; set; }
        /// <summary> The name of the parent TumblingWindowTrigger to get the child rerun triggers. </summary>
        public string ParentTriggerName { get; set; }
    }
}