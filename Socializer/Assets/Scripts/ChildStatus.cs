using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChildStatus : NpcStatus
{
    public Button goodtalk, badtalk;
    public Text Childreliability;
    
    

    void Start()
    {
        reliability = 80;
        Button goodclick = goodtalk.GetComponent<Button>();
        Button badclick = badtalk.GetComponent<Button>();
        goodtalk.onClick.AddListener(upreliability);
        badtalk.onClick.AddListener(downreliability);
        
    }
    void FixedUpdate()
    {
        Childreliability.text = string.Format("({0}/{1})", reliability, max_reliability);
    }
    private void upreliability()
    {
        reliability += 1.5f;
        if (reliability > max_reliability)
        {
            reliability = max_reliability;
        }
    }
    private void downreliability()
    {
        reliability -= 2;
    }
}

