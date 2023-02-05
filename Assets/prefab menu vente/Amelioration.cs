using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amelioration : MonoBehaviour
{
    [SerializeField] private GameObject speed;
    [SerializeField] private GameObject dmg;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        dmg.SetActive(!dmg.activeSelf);
        speed.SetActive(!speed.activeSelf);
        
    }
}
