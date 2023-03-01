using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip _hitSound;
    [SerializeField] private AudioClip _magicSound;

    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();

        Actions.Instance.OnHitMiddle += PlayHitSound;
        Actions.Instance.OnHitEnd += PlayMagicSound;
    }

    private void PlayMagicSound()
    {
        _audioSource.PlayOneShot(_magicSound, 0.5f);
    }

    private void PlayHitSound()
    {
        _audioSource.PlayOneShot(_hitSound, 0.5f);
    }
}
