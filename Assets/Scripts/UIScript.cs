using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScript : MonoBehaviour
{
  [SerializeField]
  public TMPro.TextMeshProUGUI healthText;

  [SerializeField]
  public TMPro.TextMeshProUGUI bulletText;
  // Start is called before the first frame update

  public PlayerHealth playerHealth;

  public PlayerShooting playerShooting;

  void Start()
  {
  }

  // Update is called once per frame
  void Update()
  {
    this.healthText.text = this.healthLabel;
    this.bulletText.text = this.bulletLabel;
  }

  string healthLabel { get { return string.Format("Health: {0}", playerHealth.GetHealth()); } set { } }
  string bulletLabel { get { return string.Format("Ammo: {0}", (playerShooting.maxNumberOfBullets - playerShooting.firedBullets)); } set { } }
}
