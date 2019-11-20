using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_inRange : MonoBehaviour
{
    public bool inRange;
    [SerializeField] SpriteRenderer circle;

    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grabbable"))
        {
            inRange = true;
            circle.color = new Color(0, .9f, .3f, .4f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Grabbable"))
        {
            inRange = false;
            circle.color = circle.color = new Color(1, 1, 1, .4f);
        }
    }
}
