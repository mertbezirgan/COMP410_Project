using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandleLevelFinish : MonoBehaviour
{
  private void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "Player")
    {
      //check for next scene existance go to next level if exists
      if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
      {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      }
      else
      {
        SceneManager.LoadScene(0);
      }
    }
  }
}
