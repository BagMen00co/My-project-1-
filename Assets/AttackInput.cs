using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInput : MonoBehaviour
{
    InteractInput interactInput;
    AttackHandle attackHandle;
    // Start is called before the first frame update
    void Awake()
    {
        interactInput = GetComponent<InteractInput>();
        attackHandle = GetComponent<AttackHandle>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            if (interactInput.hoveringoverObject != null) 
            {
                attackHandle.Attack(interactInput.hoveringoverObject);
            }
        }
    }
}
