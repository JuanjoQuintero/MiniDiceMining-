using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionEsmeralda : MonoBehaviour
{
    public ModeloDatos modeloDatos;
    public int bonificacion;
    public GameObject proximaActivacion;
    

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("DadoP1"))
        {
            GameManager.turnoJugador1 = false;
            proximaActivacion.SetActive(true);

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
            proximaActivacion.SetActive(true);

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
        if (collision.CompareTag("DadoP1"))
        {
            GameManager.turnoJugador1 = true;
            proximaActivacion.SetActive(false);

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
            proximaActivacion.SetActive(false);
        }
    }

}
