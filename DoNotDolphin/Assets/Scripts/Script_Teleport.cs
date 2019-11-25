using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Transform otherSide;
    [SerializeField] Transform playerTeleport;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player"){
            playerTeleport.position = otherSide.position;
        }
    }
}
