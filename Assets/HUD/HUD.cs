using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{   
    public int pv;
    public TextMeshProUGUI pv_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pv_text.text= ": "+pv.ToString();
    }
    public void TakeDamage(int damage){
        pv-=damage;
        if (pv<=0){
            //GAME OVER
        }
    }
}

