using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoostDmg : MonoBehaviour //METTRE UNE MMAJUSCULE AU DEBUT DES PUTAINS DE CLASSES DE SES MORTS
{
    public int max_powerup=3;
    private void OnMouseDown()
    {
        if (Money.money > 200 && max_powerup>0)
        { 
            Money.spend(200);
            max_powerup--;
            transform.parent.transform.parent
                .gameObject.GetComponent<Tourelle>().damage=transform.parent.transform.parent.gameObject.GetComponent<Tourelle>().damage*2;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
