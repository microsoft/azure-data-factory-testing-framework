from typing import List

from azure_data_factory_testing_framework.exceptions.pipeline_not_found_error import PipelineNotFoundError
from azure_data_factory_testing_framework.fabric.models.fabric_pipeline import FabricPipeline


class FabricRepository:
    def __init__(self, pipelines: List[FabricPipeline]) -> None:
        """Initializes the repository with pipelines, linkedServices, datasets and triggers.

        Args:
            pipelines: List of pipelines.
        """
        self.pipelines = pipelines

    def get_pipeline_by_name(self, name: str) -> FabricPipeline:
        """Get a pipeline by name. Throws an exception if the pipeline is not found.

        Args:
            name: Name of the pipeline.
        """
        for pipeline in self.pipelines:
            if pipeline.name == name:
                return pipeline

        raise PipelineNotFoundError(f"Pipeline with name {name} not found")
