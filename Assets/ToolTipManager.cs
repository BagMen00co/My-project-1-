using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ToolTipManager : MonoBehaviour
{
    public static ToolTipManager Instance;
    [SerializeField] TextMeshProUGUI texComponent;
    [SerializeField] MouseInput mouseInput;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }
    void Start()
    {
        gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = mouseInput.mouseInputPosition;
    }
    public void ShowToolTip(string mess)
    {
        gameObject.SetActive(true);
        texComponent.text = mess;
    }
    public void HideToolTip()
    {
        gameObject.SetActive(false);
        texComponent.text = string.Empty;
    }
}
