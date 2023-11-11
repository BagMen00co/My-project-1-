using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    [SerializeField] string postMesseage;
    public string objName;
    // Start is called before the first frame update
    private void Start()
    {
        objName = transform.name;
    }
    public void InteractAction()
    {
        Debug.Log(postMesseage);
    }
}
