using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public GameObject tourelle;

    void Start()
    {
        transform.position=GetMousePos();
    }
    void Update()
    {
        transform.position=GetMousePos();
       
    }

    Vector3 GetMousePos()
    {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z=0;
        return mousePos;
    }
}
