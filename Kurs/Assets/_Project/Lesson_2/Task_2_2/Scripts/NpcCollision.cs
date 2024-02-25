using Assets._Project.Lesson_2.Task_2_2.Scripts.Zones;
using UnityEngine;

namespace Assets._Project.Lesson_2.Task_2_2.Scripts
{
	[RequireComponent(typeof(Npc))]
	public class NpcCollision : MonoBehaviour
	{
		private Npc _npc;

		private void Awake()
		{
			_npc = GetComponent<Npc>();
		}

		private void OnTriggerEnter(Collider other)
		{
			if(other.TryGetComponent(out RestZone restZone))
			{
				_npc.Rest();
			}
			else if(other.TryGetComponent(out WorkZone workZone))
			{
				_npc.Work();
			}
		}
	}
}