using UnityEngine;

public static class GameController
{
    private static int collectibleCount;
    private static bool isGameOver = false;

    public static bool GameOver => isGameOver;
    public static bool Win => !isGameOver && collectibleCount <= 0;
    
    public static void Init()
    {
        TimerManager.currentTime = 0f;
        TimerManager.isCounting = true;
        score = 0;
        collectibleCount = 18;
        isGameOver = false;
    }

    private static int score = 0;
    public static int Score => score;

    public static void AddScore(int amount)
    {
        score += amount;
    }

    public static void Collect()
    {
        collectibleCount--;
    }

    public static void TriggerGameOver()
    {
        isGameOver = true;
    }
}
