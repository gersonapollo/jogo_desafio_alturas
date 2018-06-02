using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculo : MonoBehaviour {

	[SerializeField]
    private float tempoParaGerarObstaculo;
	[SerializeField]
	private GameObject objeto;
    private float cronometro;

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
