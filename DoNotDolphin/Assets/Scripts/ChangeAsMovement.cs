using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAsMovement : MonoBehaviour
{
    [SerializeField] Transform playerCharacter;
    [SerializeField] Material cubeMaterial;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xPos = playerCharacter.position.x;

        cubeMaterial.SetFloat("_AngleOffV", xPos);

    }
}
