using System.Collections.Generic;
using UnityEngine;

namespace _Project.Lesson_1.Task_4.Scripts
{
  public class Magistrate : MonoBehaviour
  {
    [SerializeField] private List<Ball> _balls;
    private IVictoryCondition _victoryCondition;

    public void StartAllBallCondition()
    {
      _victoryCondition = new AllBallCondition();
    }
    
    public void StartBlueBallCondition()
    {
      _victoryCondition = new NeededBallCondition(_balls, Color.Blue);
    }

    public void StartRedBallCondition()
    {
      _victoryCondition = new NeededBallCondition(_balls, Color.Red);
    }

    
    public void StartGreenBallCondition()
    {
      _victoryCondition = new NeededBallCondition(_balls, Color.Green);
    }
    
    private void OnEnable()
    {
      for (int i = 0; i < _balls.Count; i++)
      {
        _balls[i].BallTook += OnBallTook;
      }
    }

    private void OnDisable()
    {
      for (int i = 0; i < _balls.Count; i++)
      {
        _balls[i].BallTook -= OnBallTook;
      }
    }

    private void OnBallTook(Ball ball)
    {
      _balls.Remove(ball);
      bool isVictory = _victoryCondition.IsVictory(_balls);
      if (isVictory == true)
      {
        Debug.Log("You win!!!");
      }
      else if (_balls.Count == 0)
      {
        Debug.Log("You lose...");
      }
    }
  }
}