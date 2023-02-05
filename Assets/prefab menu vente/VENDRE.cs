using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VENDRE : MonoBehaviour

{
    void OnMouseDown()
    {
        Money.gain(180);
        transform.parent.transform.parent.transform.parent.transform.Find("invocation").gameObject.SetActive(true);
        Destroy(transform.parent.transform.parent.gameObject);
    }   
}
