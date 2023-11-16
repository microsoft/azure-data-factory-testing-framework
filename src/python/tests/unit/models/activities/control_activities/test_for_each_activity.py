import pytest

from azure_data_factory_testing_framework.data_factory.generated.models import (
    DataFactoryElement,
    Expression,
    ExpressionType,
    ForEachActivity,
    SetVariableActivity,
    VariableSpecification,
)
from azure_data_factory_testing_framework.data_factory.test_framework import TestFramework
from azure_data_factory_testing_framework.state import PipelineRunState


def test_when_evaluate_child_activities_then_should_return_the_activity_with_item_expression_evaluated() -> None:
    # Arrange
    test_framework = TestFramework()
    for_each_activity = ForEachActivity(
        name="ForEachActivity",
        items=Expression(type=ExpressionType.EXPRESSION, value="@split('a,b,c', ',')"),
        activities=[
            SetVariableActivity(
                name="setVariable",
                variable_name="variable",
                value=DataFactoryElement[str]("item()"),
                depends_on=[],
            ),
        ],
        depends_on=[],
    )
    state = PipelineRunState(
        variable_specifications={
            "variable": VariableSpecification(type="String"),
        },
    )

    # Act
    activities = test_framework.evaluate_activity(for_each_activity, state)

    # Assert
    set_variable_activity = next(activities)
    assert set_variable_activity is not None
    assert set_variable_activity.name == "setVariable"
    assert set_variable_activity.value.value == "a"

    set_variable_activity = next(activities)
    assert set_variable_activity is not None
    assert set_variable_activity.name == "setVariable"
    assert set_variable_activity.value.value == "b"

    set_variable_activity = next(activities)
    assert set_variable_activity is not None
    assert set_variable_activity.name == "setVariable"
    assert set_variable_activity.value.value == "c"

    # Assert that there are no more activities
    with pytest.raises(StopIteration):
        next(activities)
