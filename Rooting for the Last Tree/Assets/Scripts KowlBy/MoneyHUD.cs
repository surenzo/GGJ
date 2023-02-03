using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyHUD : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=cam.ScreenToWorldPoint(new Vector3(170f,Screen.height-18f,0))+new Vector3(0f,0f,5f);
    }
}
