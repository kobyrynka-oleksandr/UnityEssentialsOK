using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Length Settings")]
    [Tooltip("How many real seconds a full in-game day lasts")]
    [Min(1f)]
    public float dayDurationSeconds = 120f;

    [Header("Rotation Settings")]
    [Tooltip("Axis around which the light rotates")]
    public Vector3 rotationAxis = Vector3.right;

    private float degreesPerSecond;

    void Start()
    {
        RecalculateSpeed();
    }

    void OnValidate()
    {
        // Keeps speed updated when you change values in Inspector
        RecalculateSpeed();
    }

    void Update()
    {
        float rotationThisFrame = degreesPerSecond * Time.deltaTime;
        transform.Rotate(rotationAxis, rotationThisFrame, Space.World);
    }

    private void RecalculateSpeed()
    {
        if (dayDurationSeconds <= 0f)
            dayDurationSeconds = 1f;

        // 360 degrees per full day
        degreesPerSecond = 360f / dayDurationSeconds;
    }
}