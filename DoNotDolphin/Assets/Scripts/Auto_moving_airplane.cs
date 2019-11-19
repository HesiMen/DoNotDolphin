using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto_moving_airplane : MonoBehaviour
{
    public float speed = 0.1f;
    public GameObject[] children;

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(new Vector3(0, Time.deltaTime / 2 * -speed, 0));

        foreach (var child in children)
        {
            child.transform.Rotate(new Vector3(0, Time.deltaTime / 2 * -speed, 0));
        }
}
}
