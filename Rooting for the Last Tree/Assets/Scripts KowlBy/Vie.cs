using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vie : MonoBehaviour
{
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=cam.ScreenToWorldPoint(new Vector3(35f,Screen.height-23f,0))+new Vector3(0f,0f,5f);
        transform.localScale=cam.ScreenToWorldPoint(new Vector3(36f,36f,0f)) - cam.ScreenToWorldPoint(new Vector3(0f,0f,0f));
    }
}
