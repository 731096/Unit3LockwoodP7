using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 1, 0);
    private float startDely = 2;
    private float repeatRate = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDely, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle() 
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
