using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float spawnRate = 1f;
    [SerializeField] float minHeight = -1f;
    [SerializeField] float maxHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn),spawnRate,spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    void Spawn()
    {
        GameObject pipes= Instantiate(prefab,transform.position,Quaternion.identity);

        pipes.transform.position+=Vector3.up*Random.Range(minHeight,maxHeight);
    }
}
