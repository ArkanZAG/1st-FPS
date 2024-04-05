using System.Collections;
using System.Collections.Generic;
using Script.Interface;
using UnityEngine;

public class Barrel : MonoBehaviour, IShootable
{
    public void OnHit()
    {
        Debug.Log("Duar!");
    }
}
