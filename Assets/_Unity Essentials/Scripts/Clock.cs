using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Clock : MonoBehaviour
{
    private AudioSource _audio;

    private void Awake()
    {
        _audio = GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        _audio.Play();
    }
}
