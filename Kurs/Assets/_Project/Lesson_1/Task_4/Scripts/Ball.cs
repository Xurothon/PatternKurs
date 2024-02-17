using System;
using UnityEngine;

namespace _Project.Lesson_1.Task_4.Scripts
{
  public class Ball : MonoBehaviour
  {
    [SerializeField] private Color _color;
    public Color Color => _color;
    
    public event Action<Ball> BallTook;

    private void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.TryGetComponent(out Player player))
      {
        BallTook?.Invoke(this);
        Destroy(gameObject);
      }
    }
  }

  public enum Color
  {
    Red, Blue, Green
  }
}