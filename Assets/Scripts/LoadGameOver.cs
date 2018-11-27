using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGameOver : MonoBehaviour {

	public void GameOver()
    {
        SceneManager.LoadScene("Game over");
    }

}
