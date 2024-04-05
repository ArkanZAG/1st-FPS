using System.Collections;
using System.Collections.Generic;
using Script.Interface;
using UnityEngine;

public class Wall : MonoBehaviour, IShootable
{
    public void OnHit()
    {
        Debug.Log("Wall Bang!");
    }
}
