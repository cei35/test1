using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    private TextMeshProUGUI scoreValue;

    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    public void StartGame()
    {
        Debug.Log("so");
        SceneManager.LoadScene(0);
    }

    public void Exit() {
        Debug.Log("LA");
        Application.Quit();
    /*
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif*/
    }

    public void AddScore()
    {
        score++;
        scoreValue.text = score.ToString();

    }
}
