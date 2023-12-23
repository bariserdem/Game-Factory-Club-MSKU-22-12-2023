using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject block;
    public int width = 2;
    public int height = 4;

    private void Start()
    {
        //Instantiate(block, new Vector3(-1.8f, 4.48f, 0), Quaternion.identity);
        SpawnEnemy();
    }

    public void SpawnEnemy()
    {
        float width = Random.Range(-1.8f, 1.8f);
        float height = Random.Range(1f, 4f);
        Instantiate(block, new Vector3(width, height, 0), Quaternion.identity);
    }
}
