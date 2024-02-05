from typing import Union

from lark import Tree

from data_factory_testing_framework.exceptions.expression_evaluation_error import ExpressionEvaluationError
from data_factory_testing_framework.functions.evaluator.exceptions import (
    ExpressionEvaluationInvalidChildTypeError,
    ExpressionEvaluationInvalidNumberOfChildrenError,
)
from data_factory_testing_framework.functions.evaluator.rules.expression_rule import EvaluatedExpression

from .expression_rule import ExpressionRuleEvaluator


class LogicalBoolExpressionEvaluator(ExpressionRuleEvaluator):
    OR = "or"
    AND = "and"

    def __init__(self, tree: Tree) -> None:
        """Initializes the expression rule evaluator."""
        super().__init__(tree)

        if len(self.children) != 3:
            raise ExpressionEvaluationInvalidNumberOfChildrenError(required=3, actual=len(self.children))

        if not isinstance(self.children[0], EvaluatedExpression):
            raise ExpressionEvaluationInvalidChildTypeError(
                child_index=0,
                expected_types=(EvaluatedExpression,),
                actual_type=type(self.children[0]),
            )

        for i, child in enumerate(self.children[1:]):
            self._check_child_type(child, i)

        if self.children[0].value not in (self.OR, self.AND):
            self._raise_invalid_operator(self.children[0].value)

        self.logical_operator = self.children[0].value
        self.left_expression = self.children[1]
        self.right_expression = self.children[2]

    def _raise_invalid_operator(self, logical_operator: str) -> None:
        raise ExpressionEvaluationError(f"Invalid logical operator: {logical_operator}")

    def _check_child_type(self, child: Union[EvaluatedExpression, ExpressionRuleEvaluator], child_index: int) -> None:
        if not isinstance(child, (ExpressionRuleEvaluator, EvaluatedExpression)):
            raise ExpressionEvaluationInvalidChildTypeError(
                child_index=child_index,
                expected_types=(ExpressionRuleEvaluator, EvaluatedExpression),
                actual_type=type(child),
            )

    def evaluate(self) -> EvaluatedExpression:
        if self.logical_operator == self.OR:
            value = self._evaluate_expression(self.left_expression) or self._evaluate_expression(self.right_expression)
        elif self.logical_operator == self.AND:
            value = self._evaluate_expression(self.left_expression) and self._evaluate_expression(self.right_expression)
        else:
            self._raise_invalid_operator(self.logical_operator)
        return EvaluatedExpression(value)

    def _evaluate_expression(self, expression: Union[ExpressionRuleEvaluator, EvaluatedExpression]) -> bool:
        result = self.ensure_evaluated_expression(expression)
        if not isinstance(result.value, bool):
            raise ExpressionEvaluationError(f"Evaluating expression resulted in non-boolean value: {result.value}")

        return result.value
