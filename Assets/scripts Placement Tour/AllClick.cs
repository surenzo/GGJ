using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AllClick : MonoBehaviour
{

    public List<bool> t;
    public GameObject TourMenu;
    public bool surSouris;

    // Start is called before the first frame update
    void Start()
    {
        TourMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnTurretMenu()
    {
        Debug.Log(TourMenu.activeSelf);
        if(!TourMenu.activeSelf)
        TourMenu.SetActive(true);
        else
        {
        TourMenu.SetActive(false);
        surSouris=false;
        Destroy (GameObject.FindWithTag("tour"));
        }
    }



}
