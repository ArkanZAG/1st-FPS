using System.Collections;
using System.Collections.Generic;
using Script.Interface;
using UnityEngine;

public class GunRayCast : MonoBehaviour
{
    [SerializeField] private Camera camera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayCast();
        }
    }

    private void RayCast()
    {
        RaycastHit hit;
        IShootable iShootalbe;

        if (!Physics.Raycast(transform.position, camera.transform.forward, out hit)) return;
        if (!hit.collider.gameObject.TryGetComponent<IShootable>(out iShootalbe)) return;
        iShootalbe.OnHit();
    }
}
