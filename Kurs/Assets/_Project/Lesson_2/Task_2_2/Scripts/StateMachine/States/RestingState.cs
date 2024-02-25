using UnityEngine;

namespace Assets._Project.Lesson_2.Task_2_2.Scripts.StateMachine.States
{
	public class RestingState : ActionState
	{
		public RestingState(IStateSwitcher stateSwitcher, NpcStateMachineData data, Npc npc) :
			base(stateSwitcher, data, npc) {}

		public override void Enter()
		{
			base.Enter();

			Debug.Log("Start rest");

			_expectedTime = _npc.Config.RestingDuration;
		}

		public override void Exit()
		{
			Debug.Log("End Rest");
		}

		protected override void OnFinished()
		{
			_data.NextTargetTransform = _npc.WorkZonePosition;
			_stateSwitcher.SwitchState<MovingState>();
		}
	}
}