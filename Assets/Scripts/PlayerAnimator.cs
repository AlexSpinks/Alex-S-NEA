using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private PlayerMovement _playerMovement;
    private SpriteRenderer _sr;
    public Health playerHealth;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
        _sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        bool isMoving = _playerMovement.moveDir.x != 0 || _playerMovement.moveDir.y != 0;
        _animator.SetBool("Move", isMoving);

        if (isMoving)
        {
            UpdateSpriteDirection();
        }

        bool isDead = playerHealth.currentHealth <= 0;
        _animator.SetBool("Dead", isDead);

        if (isDead)
        {
            UpdateSpriteDirection();
        }

        _animator.SetBool("Attack", Input.GetKeyDown(KeyCode.Space));
    }

    private void UpdateSpriteDirection()
    {
        _sr.flipX = _playerMovement.lastHorizontalVector < 0;
    }
}
