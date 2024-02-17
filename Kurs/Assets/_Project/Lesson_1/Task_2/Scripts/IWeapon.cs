using UnityEngine;

namespace _Project.Lesson_1.Task_2.Scripts
{
  public interface IWeapon
  {
    bool HasBullets();
    void ChangeTransform(Transform transform);
    void Disable();
    void Active();
    void Shoot();
  }
}
