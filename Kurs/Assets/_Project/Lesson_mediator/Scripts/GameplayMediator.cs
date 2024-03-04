using Assets._Project.Lesson_mediator.Scripts.UI;
using System;
using UnityEngine;

namespace Assets._Project.Lesson_mediator.Scripts
{
	public class GameplayMediator : MonoBehaviour
	{
		[SerializeField] private PlayerStats _playerStats;
		[SerializeField] private PlayerStatsPanel _playerStatsPanel;
		[SerializeField] private RestartPanel _restartPanel;
		[SerializeField] private Bootstrap _bootstrap;

		private void OnEnable()
		{
			_playerStats.Died += OnPlayerDied;
			_playerStats.HealthChanged += OnPlayerHealthChanged;
			_playerStats.LevelChanged += OnPlayerLevelChanged;
			_restartPanel.RestartClicked += OnRestartClicked;
			_bootstrap.LevelRestared += OnLevelRestarted;
		}

		private void OnDisable()
		{
			_playerStats.Died -= OnPlayerDied;
			_playerStats.HealthChanged -= OnPlayerHealthChanged;
			_playerStats.LevelChanged -= OnPlayerLevelChanged;
			_restartPanel.RestartClicked -= OnRestartClicked;
			_bootstrap.LevelRestared += OnLevelRestarted;
		}

		private void OnPlayerDied()
		{
			_restartPanel.Show();
		}

		private void OnPlayerLevelChanged(int value)
		{
			_playerStatsPanel.UpdateLevel(value);
		}

		private void OnPlayerHealthChanged(int value)
		{
			_playerStatsPanel.UpdateHealth(value);
		}

		private void OnRestartClicked()
		{
			_bootstrap.Restart();
		}

		private void OnLevelRestarted()
		{
			_restartPanel.Hide();
		}
	}
}