using UnityEngine;

namespace Assets._Project.Lesson_2.Task_2_2.Scripts.StateMachine.States
{
	public class WorkingState : ActionState
	{
		public WorkingState(IStateSwitcher stateSwitcher, NpcStateMachineData data, Npc npc) :
			base(stateSwitcher, data, npc) {}

		public override void Enter()
		{
			base.Enter();

			Debug.Log("Start work");

			_expectedTime = _npc.Config.WorkingDuration;
		}

		public override void Exit()
		{
			Debug.Log("End work");
		}

		protected override void OnFinished()
		{
			_data.NextTargetTransform = _npc.RestZonePosition;
			_stateSwitcher.SwitchState<MovingState>();
		}
	}
}