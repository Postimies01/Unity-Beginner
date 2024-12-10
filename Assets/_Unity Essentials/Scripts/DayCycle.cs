using UnityEngine;

public class DayCycle : MonoBehaviour
{
    // The number of seconds in Unity time that will represent one full day cycle.
    [Tooltip("Seconds for one full day cycle.")]
    public float dayDuration = 60f;

    // This variable will store the current time of the day (0 to 1, where 0 is the start of the day and 1 is the end of the day).
    private float timeOfDay = 0f;

    void Update()
    {
        // Update the time of day based on the day duration.
        timeOfDay += Time.deltaTime / dayDuration;

        // Loop the timeOfDay back to 0 once it reaches 1 (i.e., when one day is complete).
        if (timeOfDay >= 1f)
        {
            timeOfDay = 0f;
        }

        // Rotate the light based on the time of day.
        // We multiply by 360 to make a full rotation, and multiply by timeOfDay to simulate the progress of the day.
        transform.rotation = Quaternion.Euler((timeOfDay * 360f) - 90f, 0f, 0f);
    }
}