using System;
using UnityEngine;

namespace Assets._Project.Lesson_2.Task_2_2.Scripts.StateMachine.States
{
	public class MovingState : IState
	{
		private static float FinishDistanceDelta => 0.001f;

		private readonly IStateSwitcher _stateSwitcher;
		private readonly Npc _npc;
		private readonly NpcStateMachineData _data;

		private Vector3 _targetPosition;
		private Action _switch;

		public MovingState(IStateSwitcher stateSwitcher, NpcStateMachineData data, Npc npc)
		{
			_stateSwitcher = stateSwitcher;
			_npc = npc;
			_data = data;
		}

		public void Enter()
		{
			Debug.Log("Start move");

			_targetPosition = _data.NextTargetTransform;
			_npc.RestStarted += OnSleepStated;
			_npc.WorkStarted += OnWorkStated;
		}

		public void Exit()
		{
			Debug.Log("End move");

			_npc.RestStarted -= OnSleepStated;
			_npc.WorkStarted -= OnWorkStated;
		}

		public void Update(float deltaTime)
		{
			_npc.transform.position = Vector3.MoveTowards(
				_npc.transform.position,
				_targetPosition,
				_npc.Config.MovingSpeed * deltaTime
			);

			if (Vector3.Distance(_npc.transform.position, _targetPosition) < FinishDistanceDelta)
			{
				_switch();
			}
		}

		private void OnWorkStated()
		{
			_switch = () => { _stateSwitcher.SwitchState<WorkingState>(); };
		}

		private void OnSleepStated()
		{
			_switch = () => { _stateSwitcher.SwitchState<RestingState>(); };
		}
	}
}