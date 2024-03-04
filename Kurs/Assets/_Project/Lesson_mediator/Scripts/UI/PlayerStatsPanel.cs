using TMPro;
using UnityEngine;

namespace Assets._Project.Lesson_mediator.Scripts.UI
{
	public class PlayerStatsPanel : MonoBehaviour
	{
		[SerializeField] private string _healthPrefix;
		[SerializeField] private TextMeshProUGUI _health;
		[SerializeField] private string _levelPrefix;
		[SerializeField] private TextMeshProUGUI _level;

		public void UpdateHealth(int value)
		{
			_health.text = _healthPrefix + value.ToString();
		}

		public void UpdateLevel(int value)
		{
			_level.text = _levelPrefix + value.ToString();
		}
	}
}