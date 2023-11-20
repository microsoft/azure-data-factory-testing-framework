import pytest

from azure_data_factory_testing_framework.exceptions.pipeline_not_found_error import PipelineNotFoundError
from azure_data_factory_testing_framework.models.activities.activity import Activity
from azure_data_factory_testing_framework.state import RunParameter, RunParameterType
from azure_data_factory_testing_framework.test_framework import TestFramework, TestFrameworkType


def test_execute_pipeline_activity_child_activities_executed(request: pytest.FixtureRequest) -> None:
    # Arrange
    test_framework = TestFramework(
        framework_type=TestFrameworkType.DataFactory,
        root_folder_path=request.fspath.dirname,
        should_evaluate_child_pipelines=True,
    )
    pipeline = test_framework.repository.get_pipeline_by_name("main")

    # Act
    activities = test_framework.evaluate_pipeline(
        pipeline,
        [
            RunParameter(RunParameterType.Pipeline, "Url", "https://example.com"),
            RunParameter(RunParameterType.Pipeline, "Body", '{ "key": "value" }'),
        ],
    )
    child_web_activity: Activity = next(activities)

    # Assert
    assert child_web_activity is not None
    assert child_web_activity.name == "API Call"
    assert child_web_activity.type_properties["url"].value == "https://example.com"
    assert child_web_activity.type_properties["body"].value == '{ "key": "value" }'

    with pytest.raises(StopIteration):
        next(activities)


def test_execute_pipeline_activity_evaluate_child_pipelines_child_pipeline_not_known_exception_thrown(
    request: pytest.FixtureRequest
) -> None:
    # Arrange
    test_framework = TestFramework(
        framework_type=TestFrameworkType.DataFactory,
        root_folder_path=request.fspath.dirname,
        should_evaluate_child_pipelines=True,
    )
    test_framework.repository.pipelines.remove(test_framework.repository.get_pipeline_by_name("child"))
    pipeline = test_framework.repository.get_pipeline_by_name("main")

    # Act & Assert
    with pytest.raises(PipelineNotFoundError) as exception_info:
        next(
            test_framework.evaluate_pipeline(
                pipeline,
                [
                    RunParameter(RunParameterType.Pipeline, "Url", "https://example.com"),
                    RunParameter(RunParameterType.Pipeline, "Body", '{ "key": "value" }'),
                ],
            ),
        )

    assert exception_info.value.args[0] == "Pipeline with name Pipeline with name child not found not found"