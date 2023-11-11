using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolTip : MonoBehaviour
{
    [SerializeField] string message;
    private void OnMouseEnter()
    {
        ToolTipManager.Instance.ShowToolTip(message);
    }
    private void OnMouseExit()
    {
        ToolTipManager.Instance.HideToolTip();
    }
}
