using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int countdowntime;
    public Text countdowndisplay;
    
    private void Start(){
        StartCoroutine(CountdownToStart());
    }

    public IEnumerator CountdownToStart(){
        while(countdowntime > 0) {
            countdowndisplay.text = countdowntime.ToString();
            yield return new WaitForSeconds(1f);
            countdowntime--;
        }
        countdowndisplay.text = "GO !";
        yield return new WaitForSeconds(1f);
        countdowndisplay.gameObject.SetActive(false);
    }

}
// j'ai copié collé cette fonction directement dans changementniveau, elle est utilisé pour le niveau 0 :)