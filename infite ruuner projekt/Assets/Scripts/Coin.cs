using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float turnSpeed = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            return;
        }
  
        Destroy(gameObject); 

    }

    void Start()
    {
        


    }


    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
    public GameObject CoinPrefab;
    void SpawnCoins()
    {
        int CoinSpawnIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(CoinSpawnIndex).transform;

        Instantiate(CoinPrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
