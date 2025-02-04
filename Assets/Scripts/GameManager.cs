using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool gameover;
    public GameObject gameOverUI;
    void Start()
    {
        gameover = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(gameover)
        {
            return;
        }
        if(PlayerStats.Lives <= 0)
        {
            EndGame();
        }
    }

    private void EndGame()
    {
        gameover = true;
        gameOverUI.SetActive(true);
    }
}
