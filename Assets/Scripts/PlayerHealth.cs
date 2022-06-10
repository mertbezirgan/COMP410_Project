using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

  public float GetHealth()
  {
    return this.health;
  }
  public void decreaseHealth(float damage)
  {
    health -= damage;
    if (gameObject.tag == "enemy")
    {
      // Debug.Log("Health: " + health);
    }
    if (health <= 0)
    {
      //TODO game over and add particle
      Destroy(gameObject);
      if (gameObject.tag == "Player")
      {
        Debug.Log("Game Over");
        //load main menu scene
        SceneManager.LoadScene(0);
      }
    }
  }

  public void increaseHealth(float health)
  {
    if (health + this.health > 100)
    {
      this.health = 100;
    }
    else
    {
      this.health += health;
    }
  }
}
