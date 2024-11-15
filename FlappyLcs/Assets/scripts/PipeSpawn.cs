using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    public GameObject pipePrefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;

    private void OnEnable() {
        InvokeRepeating("SpawnPipe", spawnRate, spawnRate);
    }

    private void OnDisable() {
        CancelInvoke();
    }

    void SpawnPipe() {
        float height = Random.Range(minHeight, maxHeight);
        GameObject pipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);
        pipe.transform.position += Vector3.up * height;
    }

}
