using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class NpcStatus : MonoBehaviour
{
    public float reliability
    {
        get;
        protected set;
    }
    public int max_reliability = 100;
}
