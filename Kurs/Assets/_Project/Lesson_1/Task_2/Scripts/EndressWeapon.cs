using UnityEngine;

namespace _Project.Lesson_1.Task_2.Scripts
{
  public class EndressWeapon : Weapon
  {
    [SerializeField] private Transform _startBulletPTransform;

    public override void Shoot()
    {
      if (HasBullets() == true)
      {
        Bullet bullet = Instantiate(_template);
        bullet.transform.position = _startBulletPTransform.position;
        bullet.AddForce((_startBulletPTransform.position - transform.position).normalized, _shootPower);
      }
    }
  }
}