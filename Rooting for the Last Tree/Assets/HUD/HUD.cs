using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{   
    public int PV;
    public TextMeshProUGUI PV_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PV_text.text= ": "+PV.ToString();
    }
    public void TakeDamage(int damage){
        PV-=damage;
        if (PV<=0){
            //GAME OVER
        }
    }
}

