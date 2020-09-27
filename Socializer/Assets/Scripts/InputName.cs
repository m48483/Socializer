using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public InputField inputfield;
    public string SendName;
    

    // Update is called once per frame
    void Update()
    {
       
    }
    public void send()
    {
        SendName = inputfield.text;
    }
}
