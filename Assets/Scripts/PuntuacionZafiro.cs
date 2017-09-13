using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionZafiro : MonoBehaviour
{
    public int bonificacion = 0;
    public ModeloDatos modeloDatos;
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

        if(contadorActivacion > 0)
        {
            proximaActivacion.SetActive(true);
        }
        else if(contadorActivacion == 0)
        {
            proximaActivacion.SetActive(false);
        }

    }





    void OnTriggerEnter2D(Collider2D collision)
        {
        contadorDado++;
        contadorActivacion++;

        if (collision.gameObject.CompareTag("DadoP1"))
            {
                if ((collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 3 || collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion == 4))
                { 
                    modeloDatos.subirZafiro_P1();
                
                }
                else if (collision.gameObject.GetComponent<DragAndDrop>().valor + bonificacion >= 5)
                {
                
                    modeloDatos.subirZafiro_P1();
                    modeloDatos.subirZafiro_P1();
                }

            GameManager.turnoJugador1 = false;
           



        }
            else if (collision.gameObject.CompareTag("DadoP2"))
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

            
               
               
            
            }
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
        contadorDado--;
        contadorActivacion--;

        if (collision.gameObject.CompareTag("DadoP1"))
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
            
        }

            else if (collision.gameObject.CompareTag("DadoP2"))
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
            

        }
        }
    }

