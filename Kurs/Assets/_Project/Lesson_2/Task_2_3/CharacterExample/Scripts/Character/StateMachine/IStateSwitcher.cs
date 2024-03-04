using Assets._Project.Lesson_2.Task_2_3.CharacterExample.Scripts.Character.StateMachine.States;

public interface IStateSwitcher
{
    void SwitchState<State>() where State : IState;
}
