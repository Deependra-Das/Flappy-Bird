using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManagerScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _scoreText;

    [SerializeField]
    private Button _playAgainButton;

    [SerializeField]
    private GameObject _gameOverPanel;

    private int _playerScore = 0;


    [SerializeField]
    private AudioSource _dingAudioSource;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddScore()
    {
        _dingAudioSource.Play();
         _playerScore += 1;
    }

    public void UpdateScore()
    {
        _scoreText.text = _playerScore.ToString();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SetGameOver()
    {

        _gameOverPanel.SetActive(true);
    }
}
