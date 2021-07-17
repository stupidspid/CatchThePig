using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody2D _enemyRB;
    private void Start()
    {
        _enemyRB = GetComponent<Rigidbody2D>();
        StartCoroutine(MoveEnemy());
    }
    IEnumerator MoveEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            _enemyRB.velocity = new Vector2(Random.Range(-50, 50), Random.Range(-50, 50));
        }
    }
}
