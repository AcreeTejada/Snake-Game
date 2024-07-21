using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Include this for scene management

public class Timer : MonoBehaviour
{
    // Variable
    public float TimeLeft = 15; // Starts at 15 seconds
    public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        // Update the timer text initially to show the starting time
        UpdateTimer(TimeLeft);
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeLeft > 0)
        {
            TimeLeft -= Time.deltaTime;
        }
        else
        {
            Debug.Log("Game Over");
            TimeLeft = 0;
            // Load the Game Over scene
            SceneManager.LoadScene("EndScene");
        }
        UpdateTimer(TimeLeft);
    }

    void UpdateTimer(float currentTime)
    {
        // Ensure currentTime doesn't go below 0
        if (currentTime < 0) currentTime = 0;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
