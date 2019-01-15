using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameOver : MonoBehaviour {

	public void GameOver()
    {
        SceneManager.LoadScene("Game over");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void GoodEnd()
    {
        SceneManager.LoadScene("Good Game Over");
    }
}
