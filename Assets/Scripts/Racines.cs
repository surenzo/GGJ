using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racines : MonoBehaviour
{
    [SerializeField] private int waveapparition;
    [SerializeField] GameObject child;
    private bool desac=true;
    // Start is called before the first frame update
    void Start()
    {
        child.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(desac && waveapparition<=VagueHUD.Vague){
            child.SetActive(true);
            desac=false;
            AstarPath.active.Scan();
        }
    }
}
