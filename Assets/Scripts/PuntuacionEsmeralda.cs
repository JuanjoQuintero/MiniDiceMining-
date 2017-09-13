using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionEsmeralda : MonoBehaviour
{
    public ModeloDatos modeloDatos;
    public int bonificacion;
    public GameObject proximaActivacion;
    public int contadorDado = 0;
    public bool hayDado = false;
    public int contadorActivacion;

    public void Update()
    {
        if (contadorDado > 0)
        {
            hayDado = true;
        }
        else if (contadorDado == 0)
        {
            hayDado = false;
        }

        if (contadorActivacion > 0)
        {
            proximaActivacion.SetActive(true);
        }
        else if (contadorActivacion == 0)
        {
            proximaActivacion.SetActive(false);
        }

    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        contadorActivacion++;
        contadorDado++;


        if (collision.CompareTag("DadoP1"))
        {
            

            GameManager.turnoJugador1 = false;

            if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 1 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 2)
            {
                modeloDatos.subirEsmeralda_P1();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 3 && collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion <= 5)
            {
                modeloDatos.subirEsmeralda_P1();
                modeloDatos.subirEsmeralda_P1();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 6)
            {
                modeloDatos.subirEsmeralda_P1();
                modeloDatos.subirEsmeralda_P1();
                modeloDatos.subirEsmeralda_P1();
            }

           
        }
        else if (collision.CompareTag("DadoP2"))
        {
            GameManager.turnoJugador1 = true;
           

            if (collision.gameObject.GetComponent<DragAndDrop>().valor +bonificacion == 1 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 2)
            {
                modeloDatos.subirEsmeralda_P2();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 3 && collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion<= 5)
            {
                modeloDatos.subirEsmeralda_P2();
                modeloDatos.subirEsmeralda_P2();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 6)
            {
                modeloDatos.subirEsmeralda_P2();
                modeloDatos.subirEsmeralda_P2();
                modeloDatos.subirEsmeralda_P2();
            }
           
        }
    }

            private void OnTriggerExit2D(Collider2D collision)
    {
        contadorActivacion--;
        contadorDado--;

        if (collision.CompareTag("DadoP1"))
        {
            GameManager.turnoJugador1 = true;
            

            if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 1 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 2)
            {
                modeloDatos.bajarEsmeralda_P1();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion>= 3 && collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion<= 5)
            {
                modeloDatos.bajarEsmeralda_P1();
                modeloDatos.bajarEsmeralda_P1();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 6)
            {
                modeloDatos.bajarEsmeralda_P1();
                modeloDatos.bajarEsmeralda_P1();
                modeloDatos.bajarEsmeralda_P1();
            }
            
        }
        else if (collision.CompareTag("DadoP2"))
        {
            if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 1 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 2)
            {
                modeloDatos.bajarEsmeralda_P2();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 3 && collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion <= 5)
            {
                modeloDatos.bajarEsmeralda_P2();
                modeloDatos.bajarEsmeralda_P2();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 6)
            {
                modeloDatos.bajarEsmeralda_P2();
                modeloDatos.bajarEsmeralda_P2();
                modeloDatos.bajarEsmeralda_P2();
            }
            GameManager.turnoJugador1 = false;
            
        }
    }

   
}
