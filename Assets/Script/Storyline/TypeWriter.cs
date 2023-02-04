using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeWriter : MonoBehaviour
{
    public float delay = 0.1f;
    public string alltext1;
    private string currenttext = "";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
        
    }
    IEnumerator ShowText() {
        for(int i = 0; i<alltext1.Length; i++) {
            currenttext = alltext1.Substring(0,i);
            this.GetComponent<TextMeshProUGUI>().text = currenttext;
            yield return new WaitForSeconds(delay);
        }
    }
}
