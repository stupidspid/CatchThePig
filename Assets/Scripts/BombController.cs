using System.Collections;
using UnityEngine;

public class BombController : MonoBehaviour
{
    private Animator _bombAnimation;
    private BombButtonManager _buttonManager;
    private void Start()
    {
        _bombAnimation = GetComponent<Animator>();
        _buttonManager = GameObject.FindGameObjectWithTag("Put").GetComponent<BombButtonManager>();
    }
    private void OnEnable()
    {
        StartCoroutine(BombExistingTime());
    }

    private IEnumerator BombExistingTime()
    {
        yield return new WaitForSeconds(1);
        _bombAnimation.SetTrigger("Bomb");
        yield return new WaitForSeconds(3);
        _buttonManager.ActivateBomb?.Invoke();
        Damage();
        yield return new WaitForSeconds(0.1f);
        Destroy(gameObject);
    }

    private void Damage()
    {
        gameObject.AddComponent<CircleCollider2D>().radius = 100;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
