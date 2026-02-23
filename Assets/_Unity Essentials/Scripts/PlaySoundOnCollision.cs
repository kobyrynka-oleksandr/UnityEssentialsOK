using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlaySoundOnCollision : MonoBehaviour
{
    [SerializeField] private bool _isSeparated = false;

    private AudioSource _audio;
    private bool _hasSeparated = false;

    private void Awake()
    {
        _hasSeparated = _isSeparated;
        _audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!_hasSeparated)
            return;

        _audio.Play();
    }

    private void OnCollisionExit(Collision collision)
    {
        _hasSeparated = true;
    }
}
