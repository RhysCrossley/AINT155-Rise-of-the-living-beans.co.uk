using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiofordeath : MonoBehaviour {

    

	void OnDisable ()
    {
        GetComponent<AudioSource>().Play();
	}

    private void Sound()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
