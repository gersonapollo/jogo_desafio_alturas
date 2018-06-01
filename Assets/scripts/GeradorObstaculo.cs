using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculo : MonoBehaviour {

	[SerializeField]
	private float tempoParaGerarObstaculo;
	
	private float cronometro;
	[SerializeField]
	private GameObject objeto;

	private void Awake(){
		this.cronometro = this.tempoParaGerarObstaculo;
	}
	
	// Update is called once per frame
	void Update () {
		this.cronometro -= Time.deltaTime;

		if(cronometro < 0){
			GameObject.Instantiate(this.objeto, this.transform.position, Quaternion.identity);
			this.cronometro = this.tempoParaGerarObstaculo;
		}
	}
}
