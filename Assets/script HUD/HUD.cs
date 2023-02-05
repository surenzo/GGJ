using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;

public class HUD : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    public int SceneIndex;
    public static int pv;
    public TextMeshProUGUI pvtext;
    // Start is called before the first frame update
    void Start()
    {
        pv = 20;
    }

    // Update is called once per frame
    void Update()
    { 
        pvtext.text= ": "+pv.ToString();
    }
    public void TakeDamage(int damage){
        pv-=damage;
        if (pv<=0)
        {
            StartCoroutine(LoadStoryline(SceneIndex));
        }
    }

    IEnumerator LoadStoryline(int LevelIndex) {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(LevelIndex);
    }
}
