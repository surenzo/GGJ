using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class changementNiveau : MonoBehaviour
{
    
    public Animator transition;
    public float transitionTime;
    public int SceneIndex;
    
    public int countdowntime;
    public TextMeshProUGUI countdowndisplay;
    public TextMeshProUGUI vsuivante;
    
    [SerializeField] private List<GameObject> panneau_niveau;

    private bool finito;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());
        VagueHUD.VagueMax = panneau_niveau.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && spawnEnnemis.number_ennemis == 0 && finito)
        {
            finito = false;
            changer_corruption();
            VagueHUD.Vague += 1;
            StartCoroutine(CountdownToStart());
        }
    }

    void changer_corruption()
    {
        if (VagueHUD.Vague < VagueHUD.VagueMax)
        {
            panneau_niveau[VagueHUD.Vague-1].SetActive(false);
        }
        else
        {
            StartCoroutine(LoadStoryline(SceneIndex)); 
        }
    }
    
    IEnumerator CountdownToStart(){
        countdowndisplay.gameObject.SetActive(true);
        vsuivante.gameObject.SetActive(true);
        while(countdowntime > 0) {
            countdowndisplay.text = countdowntime.ToString();
            yield return new WaitForSeconds(1f);
            countdowntime--;
        }

        countdowntime = 5;
        countdowndisplay.text = "GO !";
        yield return new WaitForSeconds(1f);
        countdowndisplay.gameObject.SetActive(false);
        vsuivante.gameObject.SetActive(false);
        spawnEnnemis.number_ennemis = 0;
        spawnEnnemis.Rentrer = false;
        finito = true;
    }
    
    IEnumerator LoadStoryline(int LevelIndex) {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(LevelIndex);
    }
}
