
using GenericSingleton;
using Sound;
using UI;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class GameManager : MonoGenericSingleton<GameManager>
    {
        

        private void Start()
        {
            SoundManager.Instance.PlayMusic(SoundTypes.GameplayMusic);
        }

        public void Restart()
        {
            SoundManager.Instance.Play(SoundTypes.ButtonClick);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    
        public void ReturnMainMenu()
        {
            SoundManager.Instance.Play(SoundTypes.ButtonClick);
            SceneManager.LoadScene("MainMenu");
            Time.timeScale = 1;
        }

        #region Pause
        public void Pause()
        {
            UIHandler.Instance.PauseGame();
            SoundManager.Instance.Play(SoundTypes.Pause);
        }

        public void Resume()
        {
            UIHandler.Instance.ResumeGame();
            SoundManager.Instance.Play(SoundTypes.UnPause);
        }

        #endregion
    }
}