using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeWriterStoryline2 : MonoBehaviour
{
    public float delay = 0.1f;
    public float wait;
    public string alltext;
    private string currenttext = "";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
        
    }
    IEnumerator ShowText() {
        yield return new WaitForSeconds(wait);
        for(int i = 0; i<alltext.Length; i++) {
            currenttext = alltext.Substring(0,i);
            this.GetComponent<TextMeshProUGUI>().text = currenttext;
            yield return new WaitForSeconds(delay);
        }
    }
}
