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
    // Debug.Log("RocketBoostParticleSystem.Play()");
  }

  private void OnCollisionEnter(Collision other)
  {
    if (gameObject.tag == "enemyBullet")
    {
      if (other.gameObject.tag == "obstacle")
      {
        //destroy obstacle with particle effect
        other.gameObject.GetComponent<ObstacleDestruction>().explode();
        Destroy(gameObject);
        return;
      }
      else if (other.gameObject.tag == "Player")
      {
        other.gameObject.GetComponent<PlayerHealth>().decreaseHealth(10);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        rocketExplosionParticleSystem.Play();
        Invoke("destroy", rocketExplosionParticleSystem.main.duration);
        return;
      }
      else if (other.gameObject.tag == "environment")
      {
        rocketExplosionParticleSystem.Play();
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        Invoke("destroy", rocketExplosionParticleSystem.main.duration);
        return;
      }
    }
    else if (gameObject.tag == "bullet")
    {
      if (other.gameObject.tag == "obstacle")
      {
        //destroy obstacle with particle effect
        other.gameObject.GetComponent<ObstacleDestruction>().explode();
        Destroy(gameObject);
        return;
      }
      else if (other.gameObject.tag == "enemy")
      {
        other.gameObject.GetComponent<PlayerHealth>().decreaseHealth(34);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        rocketExplosionParticleSystem.Play();
        Invoke("destroy", rocketExplosionParticleSystem.main.duration);
        return;
      }
      else if (other.gameObject.tag == "environment")
      {
        rocketExplosionParticleSystem.Play();
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        Invoke("destroy", rocketExplosionParticleSystem.main.duration);
        return;
      }
    }


  }

  void destroy()
  {
    Destroy(gameObject);
  }
}
