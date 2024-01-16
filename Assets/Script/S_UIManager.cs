using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class S_UIManager : MonoBehaviour
{
    public TMP_Text scoretxt;
    public TMP_Text final_scoretxt;
    public int score;

    private bool IsPaused = false;

    public GameObject player_go;
    public GameObject pause_go;
    public GameObject loose_panel;

    void Start()
    {
        pause_go.SetActive(false);
        loose_panel.SetActive(false);

    }
    
    public void Update()
    {
        if (player_go != null)
        {
        score = player_go.GetComponent<S_Player>().getScore();
        scoretxt.text = score.ToString();
        }

        if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == false)
        {
            pause_go.SetActive(true);
            Time.timeScale = 0;
            IsPaused = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && IsPaused == true)
        {
            pause_go.SetActive(false);
            Time.timeScale = 1;
            IsPaused = false;
        }

        if (player_go.IsDestroyed() == true)
        {
            final_scoretxt.text = "Your Score : " + score.ToString();
            loose_panel.SetActive(true);

        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("SN_Game");
    }

    public void GoHome()
    {
        SceneManager.LoadScene("SN_Menu");
    }
}
