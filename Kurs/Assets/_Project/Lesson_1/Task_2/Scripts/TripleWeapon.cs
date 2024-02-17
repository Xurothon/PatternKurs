using UnityEngine;

namespace _Project.Lesson_1.Task_2.Scripts
{
  public class TripleWeapon : Weapon
  {
    [SerializeField] private Transform[] _startBulletsTransforms;

    public override void Shoot()
    {
      if (HasBullets() == true)
      {
        for (int i = 0; i < _startBulletsTransforms.Length; i++)
        {
          Bullet bullet = Instantiate(_template);
          bullet.transform.position = _startBulletsTransforms[i].position;
          bullet.AddForce((_startBulletsTransforms[i].position - transform.position).normalized, _shootPower);
        }
        _shootCount--;
      }
    }
  }
}