using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public Animator transition;
    public float transitionTime;
    public int SceneIndex;

    public void ChangeScene() {
        StartCoroutine(LoadStoryline(SceneIndex));
    }

    IEnumerator LoadStoryline(int LevelIndex) {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(LevelIndex);
    }

    public void Quit() {
        Application.Quit();
    }
}
