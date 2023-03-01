using UnityEngine;

public class Hammer : MonoBehaviour
{
    private const string TRIGGER_NAME = "Hit";

    private Animator _animator;
    private Animator Animator => _animator;

    private bool OnHit { get; set; } = false;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !OnHit)
            Hit();
    }

    private void Hit()
    {
        OnHit = true;
        Animator.SetTrigger(TRIGGER_NAME);
    }

    private void EndHit()
    {
        OnHit = false;
        Actions.Instance.OnHitEnd?.Invoke();
    }

    private void MiddleHit()
    {
        Actions.Instance.OnHitMiddle?.Invoke();
    }
}
