using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BoxMessage : MonoBehaviour
{
   
    [SerializeField] MouseInput mouseInput;
    [SerializeField] TextMeshProUGUI tipbox;

    private string tips;
    
    void Start()
    {
        //tipbox.text = "Missing tool tip";
       
    }

    public void CallToolTip()
    {
        this.enabled = true;
        tips = "Click to destroy";
        tipbox.text = tips;
    }
    public void DisableToolTip()
    {
        this.enabled = false;
        // update text of Text element
        
    }



   
}
