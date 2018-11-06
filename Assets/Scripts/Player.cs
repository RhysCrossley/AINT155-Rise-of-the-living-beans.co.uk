using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Animator gunAnim;

    private void Start()
    {
        gunAnim = GetComponent<Animator>();

    }

	// Use this for initialization
	//void Start () {
		
	//}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            gunAnim.SetBool("isFiring", true);
        }
        else
        {
            gunAnim.SetBool("isFiring", false);
        }

		
	}
}
