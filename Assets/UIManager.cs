using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject endGamePanel;
    public GameObject winPanel;

    private bool panelShown = false;

    void FixedUpdate()
    {
        if (GameController.Win && !panelShown)
        {
            TimerManager.isCounting = false;
            Time.timeScale = 0f;
            winPanel.SetActive(true);
            TimerManager.isCounting = false;
            panelShown = true;
        }
        else if (GameController.GameOver && !panelShown)
        {
            TimerManager.isCounting = false;
            Time.timeScale = 0f;
            endGamePanel.SetActive(true);
            panelShown = true;
        }
    }
}
