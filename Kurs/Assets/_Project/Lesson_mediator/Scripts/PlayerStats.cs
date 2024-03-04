using System;
using UnityEngine;

namespace Assets._Project.Lesson_mediator.Scripts
{
	public class PlayerStats : MonoBehaviour
	{
		private int _level;
		private int _currentHealth;
		private int _healthPerLevel;

		public event Action<int> LevelChanged;
		public event Action<int> HealthChanged;
		public event Action Died;

		public void Initialize(int level, int health, int healthPerLevel)
		{
			_level = level;
			_currentHealth = health;
			_healthPerLevel = healthPerLevel;
			LevelChanged?.Invoke(_level);
			HealthChanged?.Invoke(_currentHealth);
		}

		public void LevelUp()
		{
			_level++;
			_currentHealth += _healthPerLevel;
			LevelChanged?.Invoke(_level);
			HealthChanged?.Invoke(_currentHealth);
		}

		public void TakeDamage()
		{
			_currentHealth--;
			HealthChanged?.Invoke(_currentHealth);
			if (_currentHealth == 0)
			{
				Died?.Invoke();
			}
		}
	}
}