using GenericSingleton;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoGenericSingleton<ScoreManager>
{

    [SerializeField] private Text scoreText;
    private float _score;
    
    public void UpdateScore()
    {
        _score += 1 * Time.deltaTime; 
        scoreText.text = ((int)_score).ToString();
    }
}
