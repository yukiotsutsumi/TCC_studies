using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teste : MonoBehaviour {

    public Text scoreText;
    public Text venceu;
    private int score;

    private void Start()
    {
        score = 10;
        UpdateScore();
    }
	private void Update()
	{

	}
    public void AddScore(int newScoreValue)
    {
        score -= newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "azul") 
		{

            if (this.gameObject.tag != "azul")
            {
                Debug.Log("Errou vei");
            }
            else
            {
                Debug.Log("ACERTOU CARAI");
            }
		}

		if (other.gameObject.tag == "vermelho") 
		{
			if (this.gameObject.tag != "vermelho")
				Debug.Log ("Errou vei");
            else
            {
                Debug.Log("ACERTOU CARAI");
            }
        }

		if (other.gameObject.tag == "amarelo") 
		{
			if (this.gameObject.tag != "amarelo")
				Debug.Log ("Errou vei");
            else
            {
                Debug.Log("ACERTOU CARAI");
            }
        }

		if (other.gameObject.tag == "verde") 
		{
			if (this.gameObject.tag != "verde")
				Debug.Log ("Errou vei");
            else
            {
                Debug.Log("ACERTOU CARAI");
            }
        }

		if (other.gameObject.tag == "marrom") 
		{
			if (this.gameObject.tag != "marrom")
				Debug.Log ("Errou vei");
            else
            {
                Debug.Log("ACERTOU CARAI");
            }
        }

		if (other.gameObject.tag == "preto") 
		{
			if (this.gameObject.tag != "preto")
				Debug.Log ("Errou vei");
            else
            {
                Debug.Log("ACERTOU CARAI");
            }
        }
	}
}
