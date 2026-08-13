using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform spawnpointholder;
    [SerializeField] private GameObject hitEffect;
    [SerializeField] private GameObject appearEffect;
    [SerializeField] private TMP_Text scoreText;
    private List<Transform> allSpawns = new List<Transform>();
    private int score;

    private void Respawn()
    {
        Instantiate(hitEffect, transform.position, transform.rotation);
        Transform randomSpawn = allSpawns[Random.Range(0, allSpawns.Count)];
        transform.SetPositionAndRotation(randomSpawn.position, randomSpawn.rotation);
        Instantiate(appearEffect, transform.position, transform.rotation);
    }

    private void Score()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();

        if (score > PlayerPrefs.GetInt("Highscore"))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
    }
       
    private void GetSpawns()
    {
        foreach (Transform spawnPoint in spawnpointholder)
        {
            allSpawns.Add(spawnPoint);
        }
    }

    private void Awake()
    {
        GetSpawns();
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<AudioSource>().Play();
        Score();
        Respawn();
    }
}

