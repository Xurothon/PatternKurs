using Assets._Project.Lesson_2.Task_2_2.Scripts.StateMachine;
using Assets._Project.Lesson_2.Task_2_2.Scripts.Zones;
using System;
using UnityEngine;

namespace Assets._Project.Lesson_2.Task_2_2.Scripts
{
	[RequireComponent(typeof(Rigidbody))]
	public class Npc : MonoBehaviour
	{
		[SerializeField] private NpcConfig _config;
		private Vector3 _restZonePosition;
		private Vector3 _workZonePosition;

		private NpcStateMachine _stateMachine;

		public event Action RestStarted;
		public event Action WorkStarted;

		public NpcConfig Config => _config;
		public Vector3 RestZonePosition => _restZonePosition;
		public Vector3 WorkZonePosition => _workZonePosition;

		private void Awake()
		{
			_restZonePosition = FindObjectOfType<RestZone>().transform.position;
			_workZonePosition = FindObjectOfType<WorkZone>().transform.position;

			_stateMachine = new NpcStateMachine(this);
		}

		private void Update()
		{
			_stateMachine.Update();
		}

		public void Rest()
		{
			RestStarted?.Invoke();
		}

		public void Work()
		{
			WorkStarted?.Invoke();
		}
	}
}