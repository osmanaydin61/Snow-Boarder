using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class finishLine : MonoBehaviour
{
   [SerializeField] float finishTime = 2f;
   [SerializeField] ParticleSystem finishEffect;
   void OnTriggerEnter2D(Collider2D other) {

    if(other.tag=="Player")
    {
      finishEffect.Play();
      GetComponent<AudioSource>().Play();
      Invoke("ReloadScene",finishTime);
      
    }
    
   }

   void ReloadScene()
   {
   SceneManager.LoadScene(0);
   }
}
