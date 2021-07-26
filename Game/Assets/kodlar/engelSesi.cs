using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelSesi : MonoBehaviour
{
    public AudioSource ses;
    public AudioClip engelSes;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("trigger");
            ses.Stop();
            ses.PlayOneShot(engelSes);
        }
        
    }
}
