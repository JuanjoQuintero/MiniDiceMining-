using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercado : MonoBehaviour {

    public int esmeraldas;
    public int zafiros;
    public int rubis;
    public int valorDado;
    public int oros;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DadoP1"))
        {
            collision.gameObject.transform.SetParent(gameObject.transform);
            Debug.Log(" Hay colision");
        }
        else if (collision.CompareTag("DadoP2"))
        {
            collision.gameObject.transform.SetParent(gameObject.transform);
            Debug.Log(" hay colision");
        }
    }

}

