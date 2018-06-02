using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {
	[SerializeField]
    private float velocidade = 5f;
    [SerializeField]
    private float alturaMaxima;

	private void Awake(){
        this.transform.Translate(Vector3.up * Random.Range(-this.alturaMaxima, this.alturaMaxima));
	}

	private void Update () {
        this.transform.Translate(Vector3.left * this.velocidade);
		
	}

	private void OnTriggerEnter2D(Collider2D outro){
        this.Destruir();
	}

    private void Destruir(){
        GameObject.Destroy(this.gameObject);
    }

}
