using AzureDataFactory.TestingFramework.Models.Activities.Base;
using AzureDataFactory.TestingFramework.Models.Pipelines;
using PipelineActivity = AzureDataFactory.TestingFramework.Models.PipelineActivity;

namespace AzureDataFactory.TestingFramework.Models;

public partial class ControlActivity
{
    protected virtual List<PipelineActivity> GetNextActivities()
    {
        return new List<PipelineActivity>();
    }

    public virtual IEnumerable<PipelineActivity> EvaluateChildActivities(PipelineRunState state)
    {
        var scopedState = state.CreateIterationScope(null);
        var activities = GetNextActivities();
        foreach (var activity in ActivitiesEvaluator.Evaluate(activities, scopedState))
        {
            yield return activity;
        }
    }
}