using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionZafiro : MonoBehaviour
{
    public int bonificacion = 0;
    public ModeloDatos modeloDatos;
    public GameObject proximaActivacion;
    

  

    void OnTriggerEnter2D(Collider2D collision)
        {

            if (collision.CompareTag("DadoP1"))
            {
                if ((collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 3 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 4))
                { 
                    modeloDatos.subirZafiro_P1();
                
                }
                else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 5)
                {
                if (collision.transform.position == transform.position)
                    modeloDatos.subirZafiro_P1();
                    modeloDatos.subirZafiro_P1();
                }

            GameManager.turnoJugador1 = false; 
            proximaActivacion.SetActive(true);

        }
            else if (collision.CompareTag("DadoP2"))
            {
                if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 3 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 4)
                {
                    modeloDatos.subirZafiro_P2();
                }
                else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 5)
                {
                    modeloDatos.subirZafiro_P2();
                    modeloDatos.subirZafiro_P2();
            }
            GameManager.turnoJugador1 = true;
            proximaActivacion.SetActive(true);
        }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.CompareTag("DadoP1"))
            {
                if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 3 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 4)
                {
                    modeloDatos.bajarZafiro_P1();
                }
                else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 5)
                {
                    modeloDatos.bajarZafiro_P1();
                    modeloDatos.bajarZafiro_P1();
                }
            GameManager.turnoJugador1 = true;
            proximaActivacion.SetActive(false);
        }

            else if (collision.CompareTag("DadoP2"))
            {
                if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 3 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 4)
                {

                    modeloDatos.bajarZafiro_P2();
                }
                else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 5)
                {
                    modeloDatos.bajarZafiro_P2();
                    modeloDatos.bajarZafiro_P2();
                }
            
            GameManager.turnoJugador1 = false;
            proximaActivacion.SetActive(false);

        }
        }
    }

