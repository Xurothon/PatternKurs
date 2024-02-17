using UnityEngine;

namespace _Project.Lesson_1.Task_2.Scripts
{
  public class PlayerShooter : MonoBehaviour
  {
    [SerializeField] private Transform _weaponTransform;
    private IWeapon _weapon;
    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
      {
        _weapon.Shoot();
      }
    }

    public void SetWeapon(IWeapon weapon)
    {
      _weapon = weapon;
      _weapon.ChangeTransform(_weaponTransform);
    }
  }
}