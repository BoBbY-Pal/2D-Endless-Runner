using System;
using Sound;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartAndExit : MonoBehaviour 
{   
    [SerializeField] private Button playButton;
    [SerializeField] private Button exitButton;
    
    private void Awake() {
        playButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void Start()
    {
        SoundManager.Instance.PlayMusic(SoundTypes.Music);
    }

    private void StartGame()
    {   
        Debug.Log("Play Button Clicked");
        SoundManager.Instance.Play(SoundTypes.ButtonClick);
        SceneManager.LoadScene(1);
    }

    private void ExitGame()
    {   
        SoundManager.Instance.Play(SoundTypes.GameOver);
        Application.Quit();
    }
}
