from data_factory_testing_framework.functions.expressions.expression_activity import find_and_replace_activity
from data_factory_testing_framework.functions.expressions.expression_dataset import find_and_replace_dataset
from data_factory_testing_framework.functions.expressions.expression_iteration_item import \
    find_and_replace_iteration_item
from data_factory_testing_framework.functions.expressions.expression_linked_service import \
    find_and_replace_linked_services
from data_factory_testing_framework.functions.expressions.expression_parameter import find_and_replace_parameters
from data_factory_testing_framework.functions.expressions.expression_variable import find_and_replace_variables
from data_factory_testing_framework.models.base.run_parameter_type import RunParameterType
from data_factory_testing_framework.models.state.pipeline_run_state import PipelineRunState


class FunctionArgument:
    def __init__(self, expression: str):
        self.expression = expression.strip('\n').strip(' ')

    def evaluate(self, state: PipelineRunState):
        evaluated_expression = find_and_replace_parameters(self.expression, RunParameterType.Pipeline, state)
        evaluated_expression = find_and_replace_parameters(evaluated_expression, RunParameterType.Global, state)
        evaluated_expression = find_and_replace_variables(evaluated_expression, state)
        evaluated_expression = find_and_replace_linked_services(evaluated_expression, state)
        evaluated_expression = find_and_replace_dataset(evaluated_expression, state)
        evaluated_expression = find_and_replace_iteration_item(evaluated_expression, state)
        evaluated_expression = find_and_replace_activity(evaluated_expression, state)
        return evaluated_expression