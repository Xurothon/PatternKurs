using UnityEngine;

namespace _Project.Lesson_1.Task_3.Scripts
{
  public class NoTrade : ITrade
  {
    public void Trading()
    {
      Debug.Log("You don't have enough reputation to trade");
    }
  }
}