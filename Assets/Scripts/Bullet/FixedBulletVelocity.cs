using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedBulletVelocity : MonoBehaviour
{
  void FixedUpdate()
  {
    GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 50);
  }
}
