// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> Trigger that runs every time a custom event is received. </summary>
    public partial class CustomEventsTrigger : MultiplePipelineTrigger
    {
        /// <summary> Initializes a new instance of CustomEventsTrigger. </summary>
        /// <param name="events"> The list of event types that cause this trigger to fire. </param>
        /// <param name="scope"> The ARM resource ID of the Azure Event Grid Topic. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="events"/> or <paramref name="scope"/> is null. </exception>
        public CustomEventsTrigger(IEnumerable<BinaryData> events, string scope)
        {
            Argument.AssertNotNull(events, nameof(events));
            Argument.AssertNotNull(scope, nameof(scope));

            Events = events.ToList();
            Scope = scope;
            TriggerType = "CustomEventsTrigger";
        }

        /// <summary> Initializes a new instance of CustomEventsTrigger. </summary>
        /// <param name="triggerType"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="pipelines"> Pipelines that need to be started. </param>
        /// <param name="subjectBeginsWith"> The event subject must begin with the pattern provided for trigger to fire. At least one of these must be provided: subjectBeginsWith, subjectEndsWith. </param>
        /// <param name="subjectEndsWith"> The event subject must end with the pattern provided for trigger to fire. At least one of these must be provided: subjectBeginsWith, subjectEndsWith. </param>
        /// <param name="events"> The list of event types that cause this trigger to fire. </param>
        /// <param name="scope"> The ARM resource ID of the Azure Event Grid Topic. </param>
        internal CustomEventsTrigger(string triggerType, string description, DataFactoryTriggerRuntimeState? runtimeState, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, IList<TriggerPipelineReference> pipelines, string subjectBeginsWith, string subjectEndsWith, IList<BinaryData> events, string scope) : base(triggerType, description, runtimeState, annotations, additionalProperties, pipelines)
        {
            SubjectBeginsWith = subjectBeginsWith;
            SubjectEndsWith = subjectEndsWith;
            Events = events;
            Scope = scope;
            TriggerType = triggerType ?? "CustomEventsTrigger";
        }

        /// <summary> The event subject must begin with the pattern provided for trigger to fire. At least one of these must be provided: subjectBeginsWith, subjectEndsWith. </summary>
        public string SubjectBeginsWith { get; set; }
        /// <summary> The event subject must end with the pattern provided for trigger to fire. At least one of these must be provided: subjectBeginsWith, subjectEndsWith. </summary>
        public string SubjectEndsWith { get; set; }
        /// <summary>
        /// The list of event types that cause this trigger to fire.
        /// <para>
        /// To assign an object to the element of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public IList<BinaryData> Events { get; }
        /// <summary> The ARM resource ID of the Azure Event Grid Topic. </summary>
        public string Scope { get; set; }
    }
}