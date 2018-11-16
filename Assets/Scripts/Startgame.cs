using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour {

    public void Playgame()
    {
        SceneManager.LoadScene("Zombie shooter level 1");
    }
}
