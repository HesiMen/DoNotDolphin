using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_PickUp_Drop : MonoBehaviour
{
    public Transform onHand;
    [SerializeField] GameObject thingInRange;
    public bool inRange;
    bool holding;
    [SerializeField] GameObject circleAim;
    private void Update()
    {
        inRange = thingInRange.GetComponent<Script_inRange>().inRange;
        if (Input.GetMouseButtonDown(0))
        {
            if (inRange)
            {
                ClickandHold();
                circleAim.SetActive(false);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            ClickandLetGo();
            circleAim.SetActive(true);
        }
    }


    public void ClickandHold()
    {
        GetComponent<Rigidbody>().useGravity = false;
        this.transform.position = onHand.transform.position;
        this.transform.parent = onHand.transform;
        holding = true;
    }


    public void ClickandLetGo()
    {
        this.transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        holding = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (holding == true)
        {
            GetComponent<Rigidbody>().useGravity = true;
            this.transform.parent = null;
        }
        else
        {

        }

    }
}
