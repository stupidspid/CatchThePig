using System.Collections;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;
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

    private void OnDestroy()
    {
        _winPanel.SetActive(true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pig"))
        {
            Destroy(collision.gameObject);
        }
    }
}
