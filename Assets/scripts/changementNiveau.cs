using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    

public class changementNiveau : MonoBehaviour
{
    [SerializeField] private List<GameObject> panneau_niveau;
    public int niveau = 0;

    public spawnEnnemis ewi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ewi.number_ennemis == 0)
        {
            changer_corruption();
            transform.GetComponent<changementNiveau>()
            ewi.number_ennemis = 200;
        }
    }

    void changer_corruption()
    {
        panneau_niveau[niveau].SetActive(false);
    }
    
}
