using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject[] baraja = new GameObject[10];

     public void initDeck()
    {
        Card x = new Card();

        string Número;
        string Palo;
        string Puntuación;

        string[] num = { "As", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        Número = num[Random.Range(0, 13)];

        string[] p = { "Corazones", "Tréboles", "Picas", "Rombos" };
        Palo = p[Random.Range(0, 4)];

        if (Número == "As" || Número == "J" || Número == "Q" || Número == "K")
        {
            Puntuación = "10";
        }
        else
        {
            Puntuación = Número;
        }

        x.Número = Número;
        x.Palo = Palo;
        x.Puntuación = Puntuación;

        Debug.Log(Número + " de " + Palo + ". Puntuación: " + Puntuación);

        
    }

    
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {


            initDeck();
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
