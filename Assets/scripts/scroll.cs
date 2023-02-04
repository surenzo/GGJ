using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class scroll : MonoBehaviour
{
    private int scrolling = 100; //Screen.height /8;
    private int map_height = 25;
    private float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.y > Screen.height - scrolling && transform.position.y < map_height)
            transform.position = new Vector3(0, transform.position.y + speed, -10);
        
        if (Input.mousePosition.y < scrolling && transform.position.y > 0)
            transform.position = new Vector3(0, transform.position.y - speed, -10);
    }
}
