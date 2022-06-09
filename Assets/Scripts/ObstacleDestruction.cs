using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestruction : MonoBehaviour
{
  [SerializeField] ParticleSystem destructionParticleEffect;

  public void explode()
  {
    if (!destructionParticleEffect.isPlaying)
    {
      destructionParticleEffect.Play();
      Invoke("destroy", destructionParticleEffect.main.duration);
    }
  }

  void destroy()
  {
    Destroy(gameObject);
  }
}
