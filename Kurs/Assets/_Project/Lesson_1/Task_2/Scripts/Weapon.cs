using UnityEngine;

namespace _Project.Lesson_1.Task_2.Scripts
{
  public abstract class Weapon: MonoBehaviour, IWeapon
  {
    [SerializeField] protected int _shootCount;
    [SerializeField] protected int _shootPower;
    [SerializeField] protected bool _isEndlessBullets;
    [SerializeField] protected Bullet _template;

    public bool HasBullets()
    {
      if (_isEndlessBullets == true)
        return true;
      if (_shootCount > 0)
        return true;
      return false;
    }

    public void ChangeTransform(Transform newTransform)
    {
      transform.position = newTransform.position;
      transform.rotation = newTransform.rotation;
    }

    public void Disable()
    {
      gameObject.SetActive(false);
    }

    public void Active()
    {
      gameObject.SetActive(true);
    }

    public abstract void Shoot();
  }
}