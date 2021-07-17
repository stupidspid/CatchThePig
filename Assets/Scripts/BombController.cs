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
        yield return new WaitForSeconds(GlobalConstants.BOMB_DEEFAULT_STATE);
        _bombAnimation.SetTrigger("Bomb");

        yield return new WaitForSeconds(GlobalConstants.BOMB_PLACED_STATE);
        _buttonManager.ActivateBomb?.Invoke();
        gameObject.AddComponent<CircleCollider2D>().radius = GlobalConstants.BOMB_DAMAGE_RADIUS;

        yield return new WaitForSeconds(GlobalConstants.BOMB_ATTACK_STATE);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
