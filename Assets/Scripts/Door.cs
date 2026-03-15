using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [SerializeField] private int nextSceneIndex = 2;

    private Animator _animator;
    private bool _playerInRange;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            _playerInRange = false;
            _animator.SetBool("open", false);
        }
    }

    private void Update()
    {
        if (_playerInRange)
        {
            _animator.SetBool("open", true);

            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }
}
