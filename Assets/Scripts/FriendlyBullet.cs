using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyBullet : MonoBehaviour
{
    private float speed = 10;
    [SerializeField] private EnemySpawn enemySpawn = null;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * speed);
    }

   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
            Destroy(collision.gameObject);
            enemySpawn.SpawnEnemy();
        }
    }
}
