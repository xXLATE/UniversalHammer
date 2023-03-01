using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    [SerializeField] private ParticleSystem _createParticle;
    [SerializeField] private ParticleSystem _destroyParticle;

    private void Awake()
    {
        Actions.Instance.OnHitMiddle += PlayDestroyParticle;
        Actions.Instance.OnHitEnd += PlayCreateParticle;
    }

    private void PlayCreateParticle()
    {
        _createParticle.Play();
    }

    private void PlayDestroyParticle()
    {
        _destroyParticle.Play();
    }
}
