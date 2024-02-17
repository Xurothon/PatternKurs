using System.Collections.Generic;

namespace _Project.Lesson_1.Task_4.Scripts
{
  public interface IVictoryCondition
  {
    bool IsVictory(List<Ball> balls);
  }
}