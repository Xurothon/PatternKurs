using UnityEngine;

namespace Assets._Project.Lesson_2.Task_2_2.Scripts
{
	[CreateAssetMenu(fileName = "NpcConfig", menuName = "Configs/NpcConfig")]
	public class NpcConfig : ScriptableObject
	{
		[SerializeField] private float _restingDuration;
		[SerializeField] private float _workingDuration;
		[SerializeField] private float _movingSpeed;

		public float RestingDuration => _restingDuration;
		public float WorkingDuration => _workingDuration;
		public float MovingSpeed => _movingSpeed;
	}
}