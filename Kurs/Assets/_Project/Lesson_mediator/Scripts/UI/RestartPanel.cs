using System;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Lesson_mediator.Scripts.UI
{
	public class RestartPanel : MonoBehaviour
	{
		[SerializeField] private Button _restart;

		public event Action RestartClicked;

		private void OnEnable()
		{
			_restart.onClick.AddListener(OnRestartClick);
		}

		private void OnDisable()
		{
			_restart.onClick.RemoveListener(OnRestartClick);
		}

		public void Show() => gameObject.SetActive(true);

		public void Hide() => gameObject.SetActive(false);

		private void OnRestartClick() => RestartClicked?.Invoke();
	}
}