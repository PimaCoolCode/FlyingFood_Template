using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menü : MonoBehaviour
{
    public void StartGame()
    {

        SceneManager.LoadScene("Main");
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}

