using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkAnimationController : MonoBehaviour {

    public Rigidbody2D body;


    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        print(body.velocity);
        if (body.velocity != Vector2.zero)
        {
            anim.SetBool("isMoving", true);
        }
        else
        {
            anim.SetBool("isMoving", false);
        }
	}
}
