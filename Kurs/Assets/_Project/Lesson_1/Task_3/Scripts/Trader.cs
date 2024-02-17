using System;
using UnityEngine;

namespace _Project.Lesson_1.Task_3.Scripts
{
    public class Trader : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private int _reputationValueForMealTrade;
        [SerializeField] private int _reputationValueForWeaponTrade;
        private ITrade _currentTrade;

        private void OnValidate()
        {
            if (_reputationValueForMealTrade >= _reputationValueForWeaponTrade)
            {
                _reputationValueForWeaponTrade = _reputationValueForMealTrade + 1;
            }
        }

        private void Awake()
        {
            UpdateCurrentTrade();
        }

        private void OnEnable()
        {
            _player.ReputationChanged += OnReputationChanged;
        }

        private void OnDisable()
        {
            _player.ReputationChanged -= OnReputationChanged;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Player player))
            {
                _currentTrade.Trading();
            }
        }

        private void OnReputationChanged()
        {
            UpdateCurrentTrade();
        }

        private void UpdateCurrentTrade()
        {
            if (_player.Reputation < _reputationValueForMealTrade)
            {
                _currentTrade = new NoTrade();
            }
            else if (_player.Reputation < _reputationValueForWeaponTrade)
            {
                _currentTrade = new MealTrade();
            }
            else if (_player.Reputation >= _reputationValueForWeaponTrade)
            {
                _currentTrade = new WeaponTrade();
            }
        }
    }
}
