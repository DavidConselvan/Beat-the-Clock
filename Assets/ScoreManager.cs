using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager: MonoBehaviour
{
    public TMP_Text ScoreText;

    void Update()
    {
        if (!TimerManager.isCounting) return; 

        ScoreText.text = "Score: " + GameController.Score;
    }
}
