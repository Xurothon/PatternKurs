namespace Assets._Project.Lesson_2.Task_2_2.Scripts.StateMachine.States
{
	public abstract class ActionState : IState
	{
		protected readonly IStateSwitcher _stateSwitcher;
		protected readonly Npc _npc;
		protected readonly NpcStateMachineData _data;
		protected float _expectedTime;

		private float _timer;

		protected ActionState(IStateSwitcher stateSwitcher, NpcStateMachineData data, Npc npc)
		{
			_stateSwitcher = stateSwitcher;
			_npc = npc;
			_data = data;
		}

		public void Update(float deltaTime)
		{
			_timer += deltaTime;

			if (_timer >= _expectedTime)
			{
				OnFinished();
			}
		}

		public virtual void Enter()
		{
			_timer = 0;
		}

		public abstract void Exit();

		protected abstract void OnFinished();
	}
}