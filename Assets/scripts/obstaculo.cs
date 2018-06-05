using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour {
	[SerializeField]
    private float velocidade = 5f;
    [SerializeField]
    private float alturaMaxima;
    private Vector3 posicaoDoAviao;
    private bool pontuei;
    private Pontuacao pontuacao;

	private void Awake(){
        this.transform.Translate(Vector3.up * Random.Range(-this.alturaMaxima, this.alturaMaxima));
	}

	private void Start()
	{
        this.posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
	}

	private void Update () {
        float timeScale = Time.timeScale;
        if(timeScale != 0){
			this.transform.Translate(Vector3.left * this.velocidade);
        }
		
        if(!pontuei && this.transform.position.x < this.posicaoDoAviao.x){
            this.pontuei = true;
            this.pontuacao.AdicionarPonto();
        }
	}

	private void OnTriggerEnter2D(Collider2D outro){
        this.Destruir();
	}

    public void Destruir(){
        GameObject.Destroy(this.gameObject);
    }

}
