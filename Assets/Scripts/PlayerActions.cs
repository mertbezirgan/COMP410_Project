using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerActions : MonoBehaviour
{
  //store first transform position and rotation
  //   private Vector3 firstPosition;
  private Quaternion firstRotation;
  // Start is called before the first frame update
  void Start()
  {
    //store first transform position and rotation
    // firstPosition = transform.position;
    firstRotation = transform.rotation;
  }

  // Update is called once per frame
  void Update()
  {
    //restore to first rotation and position
    if (Input.GetKeyDown(KeyCode.R))
    {
      //   transform.position = firstPosition;
      transform.rotation = firstRotation;
    }
    else if (Input.GetKeyDown(KeyCode.L))
    {
      //Load next level
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    else if (Input.GetKeyDown(KeyCode.K))
    {
      //Load previous level
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
    else if (Input.GetKeyDown(KeyCode.H))
    {
      gameObject.GetComponent<PlayerHealth>().increaseHealth(100);
    }

  }
}
