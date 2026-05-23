using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform spawnpointholder;
    [SerializeField] private GameObject hitEffect;
    [SerializeField] private GameObject appearEffect;
    private List<Transform> allSpawns = new List<Transform>();

    private void Awake()
    {
        GetSpawns();
    }

    private void GetSpawns()
    {
        foreach (Transform spawnPoint in spawnpointholder)
        {
            allSpawns.Add(spawnPoint);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Respawn();
    }

    private void Respawn()
    {
        Instantiate(hitEffect, transform.position, transform.rotation);
        Transform randomSpawn = allSpawns[Random.Range(0, allSpawns.Count)];
        transform.SetPositionAndRotation(randomSpawn.position, randomSpawn.rotation);
        Instantiate(appearEffect)
    }
}

