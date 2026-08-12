using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int timer = 60;
    [SerializeField] private TMP_Text timertext;
    [SerializeField] private TMP_Text timesUpText;
   
    private void CountDown()
    {
        timer--;
        timertext.text = "Timer: " + timer.ToString();

        if (timer <= 0)
        {
            timesUpText.gameObject.SetActive(true);
            Invoke(nameof(Gameover),2);
            CancelInvoke(nameof(CountDown));
        }
    }

    private void Gameover()
    {
        SceneManager.LoadScene("Menu");
    }

    private void Start()
    {
        timertext.text = "Timer:" + timer.ToString();
        InvokeRepeating(nameof(CountDown), 1, 1);
    }
}  