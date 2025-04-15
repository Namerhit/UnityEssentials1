using UnityEngine;

public class DayCycle : MonoBehaviour
{
    [Tooltip("Time in real-world seconds for a full in-game day (360° rotation)")]
    [SerializeField] private float dayDurationInSeconds;

    private float rotationSpeed;

    void Start()
    {
        // Calculate rotation speed based on desired day length (degrees per second)
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate around the X-axis to simulate day/night cycle
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}