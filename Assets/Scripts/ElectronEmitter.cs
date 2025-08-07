using UnityEngine;

public class ElectronEmitter : MonoBehaviour
{
    public GameObject electronPrefab;
    public float spawnRadius = 0.2f;
    public float spawnRate = 1f; // electrons per second
    public float travelDistance = 3f; // how far electrons go

    public static ElectronEmitter instance;
    private float timer;

    void Awake()
    {
        instance = this;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f / spawnRate)
        {
            SpawnElectron();
            timer = 0f;
        }
    }

    void SpawnElectron()
    {
        Vector3 randomOffset = Random.insideUnitCircle * spawnRadius;
        Vector3 spawnPos = transform.position + randomOffset;

        GameObject electron = Instantiate(electronPrefab, spawnPos, Quaternion.identity);
        Electron eScript = electron.GetComponent<Electron>();
        if (eScript != null)
        {
            eScript.SetDestination(transform.right * travelDistance + spawnPos);
        }
    }
}
