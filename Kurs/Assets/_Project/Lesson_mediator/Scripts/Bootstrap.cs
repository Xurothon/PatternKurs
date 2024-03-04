using System;
using UnityEngine;

namespace Assets._Project.Lesson_mediator.Scripts
{
	public class Bootstrap : MonoBehaviour
	{
		[SerializeField] private PlayerStats _playerStats;

		public event Action LevelRestared;

		private void Awake()
		{
			_playerStats.Initialize(1, 1, 1);
		}

		public void Restart()
		{
			_playerStats.Initialize(1, 1, 1);
			LevelRestared?.Invoke();
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.Alpha1))
				_playerStats.LevelUp();
			if (Input.GetKeyDown(KeyCode.Alpha2))
				_playerStats.TakeDamage();
		}
	}
}