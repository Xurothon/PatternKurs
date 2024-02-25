namespace Assets._Project.Lesson_2.Task_2_2.Scripts.StateMachine.States
{
	public interface IState
	{
		void Enter();
		void Exit();
		void Update(float deltaTime);
	}
}