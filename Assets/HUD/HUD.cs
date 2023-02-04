using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public int pv;
    public TextMeshProUGUI pvtext;
    // Start is called before the first frame update
    void Start()
    {
        pv = 1;
    }

    // Update is called once per frame
    void Update()
    { 
        pvtext.text= ": "+pv.ToString();
    }
    public void TakeDamage(int damage){
        pv-=damage;
        if (pv<=0){
            //GAME OVER
        }
    }
}

