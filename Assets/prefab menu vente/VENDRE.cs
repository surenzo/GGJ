using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VENDRE : MonoBehaviour
{
    void OnMouseDown()
    {
        transform.parent.transform.parent.transform.Find("invocation").gameObject.SetActive(true);
        Destroy(transform.parent.gameObject);
    }   
}
