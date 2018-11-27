using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiofordeath : MonoBehaviour
{

    void OnDisable ()
    {
      GetComponent<AudioSource>().Play();
	}

    public void Sound()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
