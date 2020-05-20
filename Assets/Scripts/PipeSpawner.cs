using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxYpos, spawnTime;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        StartSpawningPipes();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartSpawningPipes()
    {
        InvokeRepeating("SpawnPipe", 0.2f, spawnTime);
    }

    public void StopSpawningPipes()
    {
        CancelInvoke("SpawnPipe");
    }

    void SpawnPipe()
    {
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-maxYpos, maxYpos), 0), Quaternion.identity);
    }
}
