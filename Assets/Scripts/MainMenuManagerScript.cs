using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuManagerScript : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _gameTitleText;

    [SerializeField]
    private Button _newGameButton;

    [SerializeField]
    private AudioSource _bgmMainTitleSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
