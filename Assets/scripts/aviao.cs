using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour {
    private Rigidbody2D fisica;
    [SerializeField]
    private float forca = 10;

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
        fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }
}
