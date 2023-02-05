using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AllClickButton : MonoBehaviour
{
    [SerializeField] private AllClick test;
    public GameObject Tour;

    [SerializeField] private int num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnTurret1()
    {
        if(!test.surSouris){
        GameObject T1=Instantiate(Tour);
        T1.tag="tour";
        test.t[num]=true;
        Debug.Log(test.t[num]);
        test.surSouris=true;
        }
    }

}
