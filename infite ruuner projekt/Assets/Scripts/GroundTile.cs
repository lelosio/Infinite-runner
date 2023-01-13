using UnityEngine;
//resp podłogi i przeszkód
public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    [SerializeField]
    private Transform[] obstacleSpawnPoints;
    public void Start()
{
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }
    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
            Destroy(gameObject);
    }

    private void Update()
    {
        
    }
    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        int obstacleSpawnIndex = Random.Range(0, obstacleSpawnPoints.Length);

        int coinIndex = obstacleSpawnIndex - 1;
        if(coinIndex < 0)
        {
            coinIndex += 2;
            if(coinIndex >= obstacleSpawnPoints.Length)
            {
                coinIndex = obstacleSpawnPoints.Length - 1;
            }
        }

        Transform spawnPoint = obstacleSpawnPoints[obstacleSpawnIndex].transform;

        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        SpawnCoins(coinIndex);

    }


    public GameObject coinPrefab;
    void SpawnCoins(int coinSpawnIndex)
    {
        Transform spawnPoint = obstacleSpawnPoints[coinSpawnIndex].transform;

        Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity, transform);
        //int coinsToSpawn = 0;
        //for (int i = 0; i < coinsToSpawn; i++)
        //{
        //    GameObject temp = Instantiate(coinPrefab);
        //    temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        //}
    }

    Vector3 GetRandomPointInCollider (Collider collider)
    {
        Vector3 point = new Vector3(
          Random.Range(collider.bounds.min.x, collider.bounds.max.x),
          Random.Range(collider.bounds.min.x, collider.bounds.max.y),
          Random.Range(collider.bounds.min.x, collider.bounds.max.z)
          );
          if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);

        }
        point.y = 1;
        return point;
        
    }
}
 