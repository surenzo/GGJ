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
    [SerializeField] private AudioClip sound;
    [SerializeField] private float volume;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        pv = 20;
        gameObject.AddComponent<AudioSource>();
        source = GetComponent<AudioSource>();
        volume = 50f;
        source.clip = sound;
        source.volume = volume;
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
            source.Play();
        }
    }

    IEnumerator LoadStoryline(int LevelIndex) {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(LevelIndex);
    }
}
