using System.Collections.Generic;

namespace _Project.Lesson_1.Task_4.Scripts
{
  public class AllBallCondition : IVictoryCondition
  {
    public bool IsVictory(List<Ball> balls)
    {
      return balls.Count == 0;
    }
  }
}