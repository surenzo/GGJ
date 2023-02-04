using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    

public class changementNiveau : MonoBehaviour
{
    [SerializeField] private List<GameObject> panneau_niveau;

    public spawnEnnemis ewi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnEnnemis.number_ennemis == 0)
        {
            changer_corruption();
            spawnEnnemis.number_ennemis = 5;
            VagueHUD.Vague += 1;
            spawnEnnemis.Rentrer = false;
        }
    }

    void changer_corruption()
    {
        panneau_niveau[VagueHUD.Vague].SetActive(false);
    }
    
}
