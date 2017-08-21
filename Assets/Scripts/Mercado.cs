using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mercado : MonoBehaviour {

    public int esmeraldas;
    public int zafiros;
    public int rubis;
    public int valorDado;
    public int oros;
    private bool pagoEfectuado = false;

    private void Update()
    {
        if (GameManager.p1_oro < 0)
            GameManager.p1_oro = 0;
        if (GameManager.p2_oro < 0)
            GameManager.p2_oro = 0;
        if (GameManager.p1_oro > 11)
            GameManager.p1_oro = 11;
        if (GameManager.p2_oro > 11)
            GameManager.p2_oro = 11;

    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DadoP1"))
        {
            if (GameManager.p1_esmeraldas >= esmeraldas && GameManager.p1_zafiros >= zafiros && GameManager.p1_rubis >= rubis && collision.gameObject.GetComponent<DragAndDrop>().valor >= valorDado)
            {
                GameManager.p1_esmeraldas -= esmeraldas;
                GameManager.p1_zafiros -= zafiros;
                GameManager.p1_rubis -= rubis;
                GameManager.p1_oro += oros;
                GameManager.turnoJugador1 = false;
                pagoEfectuado = true;
            }

          
        }
        else if (collision.CompareTag("DadoP2"))
        {
            if (GameManager.p2_esmeraldas >= esmeraldas && GameManager.p2_zafiros >= zafiros && GameManager.p2_rubis >= rubis && collision.gameObject.GetComponent<DragAndDrop>().valor >= valorDado)
            {
                GameManager.p2_esmeraldas -= esmeraldas;
                GameManager.p2_zafiros -= zafiros;
                GameManager.p2_rubis -= rubis;
                GameManager.p2_oro += oros;
                GameManager.turnoJugador1 = true;
                pagoEfectuado = true;
            }
        }
    }


        private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("DadoP1"))
        {

            if (pagoEfectuado)
            {
                GameManager.p1_esmeraldas += esmeraldas;
                GameManager.p1_zafiros += zafiros;
                GameManager.p1_rubis += rubis;
                GameManager.p1_oro -= oros;
                pagoEfectuado = false;
                GameManager.turnoJugador1 = true;
            }
           
        }

        else if( collision.CompareTag("DadoP2"))
        {
           if (pagoEfectuado)

            GameManager.p2_esmeraldas -= esmeraldas;
            GameManager.p2_zafiros -= zafiros;
            GameManager.p2_rubis -= rubis;
            GameManager.p2_oro += oros;
            pagoEfectuado = false;
            GameManager.turnoJugador1 = false;        
        }
        
    }
}

