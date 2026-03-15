using System.Collections;
using UnityEngine;

public class InteractPlayer : MonoBehaviour
{
    public GameObject coin;

    private AudioSource _pickup;
    private SpriteRenderer _sr;
    private Score _scoreComponent;
    private bool _collect;

    private void Start()
    {
        _pickup = GetComponent<AudioSource>();
        _sr = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _collect = true;
            _scoreComponent = collision.GetComponent<Score>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _collect = false;
        }
    }

    private void Update()
    {
        if (_collect)
        {
            if (_scoreComponent != null)
            {
                _scoreComponent.ScoreUP(1);
            }
            StartCoroutine(ChangeSprite());
            _collect = false;
        }
    }

    private IEnumerator ChangeSprite()
    {
        _pickup.Play();
        _sr.enabled = false;
        yield return new WaitForSeconds(2f);
        Destroy(coin);
    }
}
