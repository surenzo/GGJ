using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuVente : MonoBehaviour
{
    [SerializeField] GameObject boutton;
    [SerializeField] GameObject quitter;
    void OnMouseDown()
    {
        this.GetComponent<BoxCollider2D>().enabled =false;
        boutton.SetActive(true);
        quitter.SetActive(true);
    }   
}
