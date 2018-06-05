using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {
    [SerializeField]
    private Text componentePontuacao;
    private int pontos;
    private AudioSource audioPontuacao;

	private void Awake()
	{
        this.audioPontuacao = this.GetComponent<AudioSource>();
	}

	public void AdicionarPonto(){
        this.pontos++;
        componentePontuacao.text = pontos.ToString();
        audioPontuacao.Play();
    }

    public void ZerarPontuacao(){
        this.pontos = 0;
        componentePontuacao.text = pontos.ToString();
    }
}
