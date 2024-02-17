using System;
using UnityEngine;

namespace _Project.Lesson_1.Task_2.Scripts
{
  public class WeaponChanger : MonoBehaviour
  {
    [SerializeField] private SimpleWeapon _simpleWeapon;
    [SerializeField] private EndressWeapon _endressWeapon;
    [SerializeField] private TripleWeapon _tripleWeapon;
    [SerializeField] private PlayerShooter _playerShooter;
    private IWeapon _currentWeapon;

    private void Awake()
    {
      DisableAllWeapons();
      _currentWeapon = _simpleWeapon;
      _currentWeapon.Active();
      _playerShooter.SetWeapon(_currentWeapon);
    }

    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Alpha1))
      {
        ChangeWeapon(_simpleWeapon);
      }
      if (Input.GetKeyDown(KeyCode.Alpha2))
      {
        ChangeWeapon(_endressWeapon);
      }
      if (Input.GetKeyDown(KeyCode.Alpha3))
      {
        ChangeWeapon(_tripleWeapon);
      }
    }

    private void ChangeWeapon(IWeapon newWeapon)
    {
      _currentWeapon.Disable();
      _currentWeapon = newWeapon;
      _currentWeapon.Active();
      _playerShooter.SetWeapon(_currentWeapon);
    }

    private void DisableAllWeapons()
    {
      _simpleWeapon.Disable();
      _endressWeapon.Active();
    }
  }
}