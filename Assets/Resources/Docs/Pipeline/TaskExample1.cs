﻿namespace Assets.Resources.Docs.Pipeline
{
	using ProceduralLevelGenerator.Scripts.Pipeline;
	using UnityEngine;

	public class Payload
	{
		public int Number { get; set; }
	}

	[CreateAssetMenu(menuName = "Example tasks/Subtract task", fileName = "SubtractTask")]
	public class SubtractTask : PipelineTask<Payload>
	{
		public int ToSubtract;

		public override void Process()
		{
			Payload.Number -= ToSubtract;
		}
	}
}
