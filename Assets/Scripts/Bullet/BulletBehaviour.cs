using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
  [SerializeField] ParticleSystem rocketBoostParticleSystem;
  [SerializeField] ParticleSystem rocketExplosionParticleSystem;
  private void Start()
  {
    rocketBoostParticleSystem.Play();
    Debug.Log("RocketBoostParticleSystem.Play()");
  }
  void FixedUpdate()
  {
    // GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 50);
  }

  private void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "obstacle")
    {
      //destroy obstacle with particle effect
      other.gameObject.GetComponent<ObstacleDestruction>().explode();
    }
    Destroy(gameObject);
  }
}
