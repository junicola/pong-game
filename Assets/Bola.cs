using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bola : MonoBehaviour {

    float velTrans1;
    Vector2 direcao;

	void Start () {
        velTrans1 = 0.1f;
        direcao = -Vector2.one;
	}

	void Update () {
        this.transform.Translate(direcao * velTrans1);
        if(this.transform.position.y + this.transform.localScale.y/2 > Gerenciador.cantoSupDir.y){
			this.direcao.y = -this.direcao.y;	
		}
		if(this.transform.position.y + this.transform.localScale.y/2 <= Gerenciador.cantoInfEsq.y){
			this.direcao.y = -this.direcao.y;	
		}

	}
	
	private void OnTriggerEnter2D(Collider2D collision){
		if(collision.tag.Equals("RaqEsq") || collision.tag.Equals("RaqDir")){
			Debug.Log("TESTE");
			this.direcao.x = -this.direcao.x;
		}
			
	}
}
