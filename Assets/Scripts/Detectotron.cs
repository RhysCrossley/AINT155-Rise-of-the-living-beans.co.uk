using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class Detectotron : MonoBehaviour {

    public UnityEvent onDetectotron;

	private void OnTriggerEnter2D(Collider2D other)
    {
        //print("other " + other.transform);

        onDetectotron.Invoke();
    }
}
