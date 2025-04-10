using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuActions : MonoBehaviour
{
    public void StartGame()
    {
        
        TimerManager.currentTime = 0f;
        Time.timeScale = 1f; // ✅ isso garante que o jogo não fique pausado
        GameController.Init();
        TimerManager.isCounting = true;
        SceneManager.LoadScene(1); // Load the game scene
    }
    public void Menu() {
        SceneManager.LoadScene(0); // Load the menu scene
    }
}