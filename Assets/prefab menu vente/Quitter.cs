using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitter : MonoBehaviour
{
    [SerializeField] GameObject boutton;

    void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        boutton.SetActive(false);
        transform.parent.transform.Find("Square").GetComponent<BoxCollider2D>().enabled =true;
    }
}
