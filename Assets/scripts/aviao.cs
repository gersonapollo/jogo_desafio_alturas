using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aviao : MonoBehaviour {
    Rigidbody2D fisica;

	private void Awake()
	{
        fisica = this.GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	private void Update () {
        if(Input.GetMouseButtonDown(0)){
            this.impulsionar();
        }
	}

    private void impulsionar()
    {
        fisica.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
    }
}
