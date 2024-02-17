using System;
using UnityEngine;

namespace _Project.Lesson_1.Task_3.Scripts
{
    public class Player : MonoBehaviour
    {
        public int Reputation { get; private set; }
        public event Action ReputationChanged;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Reputation--;
                ReputationChanged?.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                Reputation++;
                ReputationChanged?.Invoke();
            }
        }
    }
}
