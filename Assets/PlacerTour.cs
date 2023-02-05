using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlacerTour : MonoBehaviour
{
    [SerializeField] GameObject moi;
    public List<GameObject> Tourelles;
    public AllClick random;
void OnMouseDown()
    {
        for(int i =0; i< Tourelles.Count; i++){
        if(random.t[i] && random.surSouris)
        {
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
