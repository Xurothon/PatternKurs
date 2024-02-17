using System.Collections.Generic;

namespace _Project.Lesson_1.Task_4.Scripts
{
  public class NeededBallCondition : IVictoryCondition
  {
    private int _noNeededBallCount;
    private Color _neededColor; 

    private NeededBallCondition() { }

    public NeededBallCondition(List<Ball> balls, Color neededColor)
    {
      _neededColor = neededColor;
      int neededBallsCount = СalculateNeededBallsCount(balls, _neededColor);
      _noNeededBallCount = balls.Count - neededBallsCount;
    }

    public bool IsVictory(List<Ball> balls)
    {
      int neededBallsCount = СalculateNeededBallsCount(balls, _neededColor);
      if (neededBallsCount == 0 && balls.Count == _noNeededBallCount)
      {
        return true;
      }

      return false;
    }

    private int СalculateNeededBallsCount(List<Ball> balls, Color neededColor)
    {
      int neededBallsCount = 0;
      
      for (int i = 0; i < balls.Count; i++)
      {
        if (balls[i].Color == neededColor)
        {
          neededBallsCount++;
        }
      }

      return neededBallsCount;
    }
  }
}