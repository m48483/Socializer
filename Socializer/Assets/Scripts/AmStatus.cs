using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmStatus : NpcStatus
{
    public Text Amreliability;
    void Start()
    {
        reliability = 10;
    }

    void FixedUpdate()
    {
        Amreliability.text = string.Format("({0}/{1})", reliability, max_reliability);
    }
    private void upreliability()
    {
        
    }
    private void downreliability()
    {

    }
}
