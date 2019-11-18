using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PickUp_Drop : MonoBehaviour
{
    
    public Transform onHand;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        rb.useGravity = false;
        this.transform.position = onHand.transform.position;
        this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
    }

    void OnMouseUp()
    {
        this.transform.parent = null;
       rb.useGravity = true;
    }
}
