using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInput : MonoBehaviour
{
    public Vector3 mouseInputPosition;
        // Update is called once per frame
    void Update()
    {
        Ray RayMoveCamera = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(RayMoveCamera, out hit,float.MaxValue))
        {
            mouseInputPosition = hit.point;
        }
    }
}
