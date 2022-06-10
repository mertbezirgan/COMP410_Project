using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
  private void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "Player")
    {
      other.gameObject.GetComponent<PlayerHealth>().increaseHealth(30);
      other.gameObject.GetComponent<PlayerShooting>().increaseAmmo(15);
      Destroy(gameObject);
    }
    else if (other.gameObject.tag == "bullet" || other.gameObject.tag == "enemyBullet")
    {
      //   Destroy(gameObject);
      Destroy(other.gameObject);
    }
  }
}
