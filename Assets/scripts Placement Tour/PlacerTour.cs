using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacerTour : MonoBehaviour
{
    public List<GameObject> Tourelles;
    public AllClick random;
    public List<int> thune_de_la_tour ;
void OnMouseDown()
    {
        for(int i =0; i< Tourelles.Count; i++){
        if(random.t[i] && random.surSouris && Money.money > thune_de_la_tour[i])
        {
            Money.spend(thune_de_la_tour[i]);
            Destroy (GameObject.FindWithTag("tour"));
            GameObject tour = Instantiate(Tourelles[i],transform.parent,true);
            tour.transform.position=transform.position;
            random.t[i]=false;
            random.surSouris=false;
            this.gameObject.SetActive(false);
        }
        }

    }   

}
