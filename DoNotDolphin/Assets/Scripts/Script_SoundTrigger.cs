using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_SoundTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioSource warpSound;
 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            warpSound.loop = true;
            warpSound.Play();
        }
    }
}
