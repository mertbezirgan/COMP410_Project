using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
  [SerializeField] GameObject player;
  public GameObject bulletPrefab;
  public float bulletForce;
  float threshold = 40f;
  bool isEnabled = true;
  float lastShotTime = 0f;
  float cooldown = 2f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Vector3.Distance(transform.position, player.transform.position) < threshold)
    {
      isEnabled = true;
    }
    if (isEnabled)
    {
      //call shoot function every x seconds x is between 2 and 6
      if (Time.time - lastShotTime > cooldown)
      {
        shoot();
        cooldown = Random.Range(2, 6);
        lastShotTime = Time.time;
      }
    }
  }

  private void FixedUpdate()
  {
    transform.LookAt(player.transform);
  }

  void shoot()
  {
    GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
    // Debug.Log(Vector3.Distance(transform.position, player.transform.position));
    // bullet.transform.LookAt(player.transform);
    bullet.transform.Translate(0, 1.05f, 0);
    //rotate bullet object to up (positive y axis)

    bullet.transform.Rotate(-8.2f, 0, 0);
    //change bullets rotation to direction that is faced by player
    Rigidbody rb = bullet.GetComponent<Rigidbody>();
    rb.AddForce(transform.forward * bulletForce, ForceMode.VelocityChange);
    Debug.Log(rb.velocity);
  }
}
