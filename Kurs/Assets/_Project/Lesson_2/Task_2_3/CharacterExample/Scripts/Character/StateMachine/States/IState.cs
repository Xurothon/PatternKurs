namespace Assets._Project.Lesson_2.Task_2_3.CharacterExample.Scripts.Character.StateMachine.States
{
	public interface IState
	{
		void Enter();
		void Exit();
		void HandleInput();
		void Update();
	}
}