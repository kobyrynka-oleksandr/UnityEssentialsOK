using UnityEngine;
using UnityEngine.InputSystem;

public class ClockPlaySoundTrigger : MonoBehaviour
{
    [SerializeField] private Clock _clock;
    private bool _hasPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<SimpleCameraController>())
        {
            _hasPlayer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<SimpleCameraController>())
        {
            _hasPlayer = false;
        }
    }

    private void Update()
    {
        if (_hasPlayer && Mouse.current.leftButton.wasPressedThisFrame)
        {
            if (_clock != null)
            {
                _clock.PlaySound();
            }
        }
    }
}
