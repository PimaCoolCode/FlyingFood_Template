using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menü : MonoBehaviour
{
    [SerializeField] private TMP_Text highscoreText;
    public void StartGame()
    {

        SceneManager.LoadScene("Main");
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore");
    }
}
