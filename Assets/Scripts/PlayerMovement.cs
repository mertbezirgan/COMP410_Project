using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  float startingZPos;
  Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    startingZPos = transform.position.z;
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    //apply force on x axis for left right movement
    if (Input.GetKey(KeyCode.A))
    {
      rb.AddForce(Vector3.left * 5000 * Time.deltaTime);
    }
    else if (Input.GetKey(KeyCode.D))
    {
      rb.AddForce(Vector3.right * 5000 * Time.deltaTime);
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      transform.position = new Vector3(transform.position.x, transform.position.y, startingZPos);
    }
  }

  void FixedUpdate()
  {
    rb.velocity = new Vector3(0, 0, 15);
  }

}
