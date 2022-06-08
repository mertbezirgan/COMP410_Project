using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10, 0, Input.GetAxis("Vertical") * Time.deltaTime * 10);
  }

}
