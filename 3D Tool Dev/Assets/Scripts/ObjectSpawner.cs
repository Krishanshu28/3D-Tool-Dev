using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public GameObject spherePrefab;
    public GameObject capsulePrefab;
    public GameObject cylinderPrefab;
    public Transform spawnPoint;

    public void SpawnCube()
    {
        SpawnObject(cubePrefab);
    }

    public void SpawnSphere()
    {
        SpawnObject(spherePrefab);
    }

    public void SpawnCapsule()
    {
        SpawnObject(capsulePrefab);
    }

    public void SpawnCylinder()
    {
        SpawnObject(cylinderPrefab);
    }

    //Spawner function
    private void SpawnObject(GameObject prefab)
    {
        if (prefab != null)
        {
            Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        }
    }
}
