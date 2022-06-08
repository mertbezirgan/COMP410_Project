using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
  float health = 100f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  public void decreaseHealth(float damage)
  {
    health -= damage;
    Debug.Log("Health: " + health);
    if (health <= 0)
    {
      //TODO game over and add particle
      Destroy(gameObject);
    }
  }
}
