using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public GameObject[] vehiclePrefabs;
    private float spawnDelay = 0.5f;
    private float spawnInterval = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnVehicle", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnVehicle()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-1, 2) * 6, 0f, 180f);
        int vehicleIndex = Random.Range(0, vehiclePrefabs.Length);
        Quaternion vehicleRotation = Quaternion.Euler(0, 180, 0);

        Instantiate(vehiclePrefabs[vehicleIndex], spawnPos, vehicleRotation);
    }
}
