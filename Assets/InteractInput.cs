using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractInput : MonoBehaviour
{
    [SerializeField] TMPro.TextMeshProUGUI textOnScreen;
    public Interact hoveringoverObject;

    // Update is called once per frame
    void Update()
    {
        CheckInteractiveObject();
        if (Input.GetMouseButtonDown(0))
        {
            if (hoveringoverObject != null)
            {
                hoveringoverObject.InteractAction();

            }
        }
    }

    private void CheckInteractiveObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {

            Interact Interactbox = hit.transform.GetComponent<Interact>();
            if (Interactbox != null)
            {
                hoveringoverObject = Interactbox;
                textOnScreen.text = hoveringoverObject.objName;
            }
            else
            {
                hoveringoverObject = null;
                textOnScreen.text = "";
            }

        }
    }
}
