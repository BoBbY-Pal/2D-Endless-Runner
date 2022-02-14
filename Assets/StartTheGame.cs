using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartTheGame : MonoBehaviour 
{   
    public Button playButton;
    public Button exitButton;
    private void Awake() {
        playButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    private void ExitGame()
    {   
        // SoundManager.Instance.Play(Sounds.ExitButtonClick);
        SceneManager.LoadScene(0);
    }
    private void StartGame()
    {   
        Debug.Log("Play Button Clicked");
        // SoundManager.Instance.Play(Sounds.RestartButtonClick);
        SceneManager.LoadScene(1); 
    }
}