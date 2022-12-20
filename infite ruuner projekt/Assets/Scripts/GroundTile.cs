using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    private void Start()
{
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }
    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
            Destroy(gameObject, 2);
    }

    private void Update()
    {
        
    }
    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        int obstacleSpwantIndex = Random.Range(2, 5);
        Transform spwanPoint = transform.GetChild(obstacleSpwantIndex).transform;

        Instantiate(obstaclePrefab, spwanPoint.position, Quaternion.identity, transform);
    }

}
 