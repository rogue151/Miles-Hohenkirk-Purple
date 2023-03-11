using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Game Over Canvas that is used for the game
    [Header("Game Over UI Object for Displaying Game Over Screen")]
    public GameObject gameOverCanvas;
    //Score Canvas that is used for the game
    [Header("Score UI Object for Displaying Score")]
    public GameObject scoreCanvas;
    //Spawner object that is used for the Game
    [Header("Spawner Object for Spawning Objects in Game")]
    public GameObject spawner;

    // Start is called before the first frame update
    void Start()
    {
        //Speed for the game is at a playing state
        Time.timeScale = 1;
        //Score invisible
        scoreCanvas.SetActive(true);
        //Game Over UI is invisible
        gameOverCanvas.SetActive(false);
        //The spawner is shown in the game
        spawner.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        //Game Over UI is visible
        gameOverCanvas.SetActive(true);
        //The spawner is now invisble in the game
        spawner.SetActive(false);
        //The speed for the game game is now at a stopping state
        Time.timeScale = 0;
    }
}
