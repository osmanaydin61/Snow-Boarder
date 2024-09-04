using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashDedector : MonoBehaviour
{
    [SerializeField] float crashTime = 2f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool audiosfx=true;
    void OnTriggerEnter2D(Collider2D other) {
        
        if(other.tag=="Ground"&&audiosfx)
        {
            FindAnyObjectByType<playerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("CrashScene",crashTime);
            audiosfx=false;
            
            
        }
    }
    void CrashScene()
   {
   SceneManager.LoadScene(0);
   }
}
