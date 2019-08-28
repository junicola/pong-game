using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    public static int pontos1;
    public static int pontos2;

    public Text score1;
    public Text score2;

    void Start()
    {
        
    }

    void Update()
    {
        score1.text = pontos1.ToString();
        score2.text = pontos2.ToString();
    }
}
