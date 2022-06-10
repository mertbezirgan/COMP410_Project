using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
  public GameObject bulletPrefab;
  public float bulletForce;

  public int maxNumberOfBullets = 40;
  public int firedBullets = 0;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Mouse0) && firedBullets < maxNumberOfBullets && PauseMenu.GameIsPaused == false)
    {
      shoot();
    }
  }

  void shoot()
  {
    GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
    //z 2.6
    //y 0.7
    bullet.transform.Translate(0, 0.3f, 2.6f);
    //rotate bullet object to up (positive y axis)
    // bullet.transform.Rotate(-5, 0, 0);
    //change bullets rotation to direction that is faced by player
    Rigidbody rb = bullet.GetComponent<Rigidbody>();
    rb.AddForce(transform.forward * bulletForce, ForceMode.Impulse);
    this.firedBullets++;
  }

  public void increaseAmmo(int number)
  {
    this.maxNumberOfBullets += number;
  }
}
