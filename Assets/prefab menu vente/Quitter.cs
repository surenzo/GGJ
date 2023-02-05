using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitter : MonoBehaviour
{
    [SerializeField] GameObject boutton;

    void OnMouseDown()
    {
        transform.parent.gameObject.SetActive(false);
        boutton.SetActive(false);
        transform.parent.transform.parent.transform.Find("Square").GetComponent<BoxCollider2D>().enabled =true;
    }
}
