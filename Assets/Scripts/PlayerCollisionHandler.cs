using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionHandler : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  private void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "obstacle")
    {
      GetComponent<PlayerHealth>().decreaseHealth(5);
      other.gameObject.GetComponent<ObstacleDestruction>().explode();
    }
  }

}
