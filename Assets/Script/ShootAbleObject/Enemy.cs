using System;
using System.Collections;
using System.Collections.Generic;
using Script.Interface;
using UnityEngine;

public class Enemy : MonoBehaviour,IShootable
{
    public void OnHit()
    {
        gameObject.SetActive(false);
    }
}
