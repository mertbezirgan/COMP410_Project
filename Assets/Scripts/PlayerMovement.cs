using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  float startingZPos;
  // Start is called before the first frame update
  void Start()
  {
    startingZPos = transform.position.z;
  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10, 0, 1 * Time.deltaTime * 10);

    if (Input.GetKeyDown(KeyCode.Space))
    {
      transform.position = new Vector3(transform.position.x, transform.position.y, startingZPos);
    }
  }

}
