using GenericSingleton;
using Sound;
using UnityEngine;

namespace UI
{
    public class UIHandler : MonoGenericSingleton<UIHandler>
    {
        [SerializeField] private GameObject  gameOverPanel;
        [SerializeField] private GameObject pauseMenu;
        
        public void PauseGame()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        
        public void ResumeGame()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
        public void GameOver()
        {
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            SoundManager.Instance.Play(SoundTypes.GameOver);
        }
    }
}