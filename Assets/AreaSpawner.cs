using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class AreaSpawner : MonoBehaviour
{
    public GameObject prefab;
    
    public Vector2 areaSize = new Vector2(5f, 5f);
    
    public bool spawnOnStart = true;
    public float timer;
    

    private void Update()
    {
        timer -= Time.deltaTime;
        if (0 >= timer)
        {
            Spawn();
            timer = 3;
        }
    }

    public void Spawn()
    {
        Vector2 randomPos = GetRandomPosition();
        Instantiate(prefab, randomPos, Quaternion.identity);
    }

    private Vector2 GetRandomPosition()
    {
        float x = Random.Range(-areaSize.x / 2f, areaSize.x / 2f);
        float y = Random.Range(-areaSize.y / 2f, areaSize.y / 2f);
        return new Vector2(transform.position.x + x, transform.position.y + y);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawCube(transform.position, new Vector3(areaSize.x, areaSize.y, 0.1f));
    }
}
