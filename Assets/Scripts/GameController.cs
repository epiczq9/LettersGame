using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public AudioSource loseSFX;
    public GameObject dingSFX;
    public GameObject tickTockSFX;
    public GameObject disablePanel;
    bool timerRunning = true;
    float timerMax = 10f;
    float timerElapsed = 0f;
 
    private void Update() {
        if (timerRunning) {
            RunTimer();
        }
    }
    public void RunTimer() {
        timerElapsed += Time.deltaTime;
        Debug.Log(timerElapsed);
        if(timerElapsed >= timerMax) {
            timerRunning = false;
            LoseGame();
        }
    }
    public void RestartTimer() {
        tickTockSFX.GetComponent<AudioSource>().Stop();
        dingSFX.GetComponent<AudioSource>().Play();
        tickTockSFX.GetComponent<AudioSource>().Play();

        timerElapsed = 0;
    }
    public void LoseGame() {
        disablePanel.SetActive(true);
        loseSFX.Play(0);
        tickTockSFX.GetComponent<AudioSource>().Stop();

    }
    public void RestartScene() {
        SceneManager.LoadScene(0);
    }
}
