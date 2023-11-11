using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    [SerializeField] MouseInput mouseInput;
    PlayerMovement characterMovement;

    // Update is called once per frame
    private void Awake()
    {
        characterMovement = GetComponent<PlayerMovement>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            characterMovement.SetDestination(mouseInput.mouseInputPosition);
        }
    }
}
