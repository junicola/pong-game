using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gerenciador : MonoBehaviour {

    public static Vector2 cantoInfEsq;
    public static Vector2 cantoSupDir;
    float velTrans1;
    public GameObject RaqEsq;
    public GameObject RaqDir;

    void Start () {
        velTrans1 = 0.2f;
        cantoInfEsq = Camera.main.ScreenToWorldPoint(new Vector2(0,0));
        cantoSupDir = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width-1,Screen.height-1));
	}

    void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            moveParaCima(RaqEsq);
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveParaBaixo(RaqEsq);
        }
        if (Input.GetKey(KeyCode.O))
        {
            moveParaCima(RaqDir);
        }
        if (Input.GetKey(KeyCode.L))
        {
            moveParaBaixo(RaqDir);
        }


	}

    void moveParaCima(GameObject g)
    {
        if(g.transform.position.y + g.transform.localScale.y/2 < cantoSupDir.y)
             g.transform.Translate(0, velTrans1, 0);
    }
     void moveParaBaixo(GameObject g)
    {
        if (g.transform.position.y + g.transform.localScale.y / 2 > cantoInfEsq.y)
            g.transform.Translate(0, -velTrans1, 0);
    }

}
