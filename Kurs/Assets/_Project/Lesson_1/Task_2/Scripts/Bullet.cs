using UnityEngine;

namespace _Project.Lesson_1.Task_2.Scripts
{
  [RequireComponent(typeof(Rigidbody))]
  public class Bullet:MonoBehaviour
  {
    private Rigidbody _rigidbody;

    private void Awake()
    {
      _rigidbody = GetComponent<Rigidbody>();
      Destroy(gameObject, 5f);
    }

    public void AddForce(Vector3 direction, int shootPower)
    {
      _rigidbody.AddForce(direction * shootPower, ForceMode.Impulse);
    }
  }
}