using Assets._Project.Lesson_2.Task_2_2.Scripts.StateMachine.States;

namespace Assets._Project.Lesson_2.Task_2_2.Scripts.StateMachine
{
	public interface IStateSwitcher
	{
		void SwitchState<TState>() where TState : IState;
	}
}