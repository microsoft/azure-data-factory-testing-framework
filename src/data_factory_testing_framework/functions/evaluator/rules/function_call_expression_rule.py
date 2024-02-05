import inspect
from typing import Callable, Union

from lark import Tree

from data_factory_testing_framework.exceptions.expression_evaluation_error import ExpressionEvaluationError
from data_factory_testing_framework.functions.evaluator.exceptions import ExpressionEvaluationInvalidChildTypeError
from data_factory_testing_framework.functions.evaluator.rules.expression_rule import (
    EvaluatedExpression,
    ExpressionRuleEvaluator,
)
from data_factory_testing_framework.functions.functions_repository import FunctionsRepository


class FunctionCallExpressionRuleEvaluator(ExpressionRuleEvaluator):
    def __init__(self, tree: Tree) -> None:
        """Initializes the expression rule evaluator."""
        super().__init__(tree)

        if len(self.children) < 1:
            raise ExpressionEvaluationError(
                f"Invalid number of children. Minimum required: 1, Actual: {len(self.children)}"
            )

        if not isinstance(self.children[0], EvaluatedExpression):
            raise ExpressionEvaluationInvalidChildTypeError(
                child_index=0, expected_types=EvaluatedExpression, actual_type=type(self.children[0])
            )

        for i, child in enumerate(self.children[1:]):
            if isinstance(child, (EvaluatedExpression, ExpressionRuleEvaluator)):
                continue

            raise ExpressionEvaluationInvalidChildTypeError(
                child_index=i, expected_types=(EvaluatedExpression, ExpressionRuleEvaluator), actual_type=type(child)
            )

        self.function_name = self.children[0].value
        self.parameters = self.children[1:]

    def evaluate(self) -> EvaluatedExpression:
        evaluated_parameters = self._evaluated_parameters(self.parameters)
        function: Callable = FunctionsRepository.functions.get(self.function_name)

        pos_or_kw_params, var_pos_params = self._build_function_call_parameters(function, evaluated_parameters)
        result = function(*pos_or_kw_params, *var_pos_params)

        return EvaluatedExpression(result)

    def _build_function_call_parameters(
        self, function: Callable, parameters: list[Union[EvaluatedExpression, ExpressionRuleEvaluator]]
    ) -> tuple[
        Union[
            list[Union[EvaluatedExpression, ExpressionRuleEvaluator]],
            list[Union[EvaluatedExpression, ExpressionRuleEvaluator]],
        ]
    ]:
        function_signature = inspect.signature(function)
        pos_or_keyword_parameters = [
            param
            for param in function_signature.parameters.values()
            if param.kind == inspect.Parameter.POSITIONAL_OR_KEYWORD
        ]

        pos_or_keyword_values = parameters[: len(pos_or_keyword_parameters)]
        var_positional_values = parameters[len(pos_or_keyword_parameters) :]
        # TODO: implement automatic conversion of parameters based on type hints
        return pos_or_keyword_values, var_positional_values

    def _evaluated_parameters(
        self, parameters: list[Union[EvaluatedExpression, ExpressionRuleEvaluator]]
    ) -> list[EvaluatedExpression]:
        evaluated_parameters = []
        for p in parameters:
            evaluated_expression = self.ensure_evaluated_expression(p)
            evaluated_parameters.append(evaluated_expression.value)
        return evaluated_parameters
