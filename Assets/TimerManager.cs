using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public TMP_Text timeText;

    public static float currentTime = 0f;
    public static bool isCounting = true;

    void Update()
    {
        if (!isCounting) return;

        currentTime += Time.deltaTime;

        int seconds = Mathf.FloorToInt(currentTime);
        timeText.text = "Time: " + seconds + "s";

        if (currentTime >= 15f)
        {
            GameController.TriggerGameOver();
            isCounting = false;
        }
    }

}
