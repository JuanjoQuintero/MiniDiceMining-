using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionRubi : MonoBehaviour
{
    public ModeloDatos modeloDatos;
    
    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("DadoP1"))
        {
            
            if (collision.gameObject.GetComponent<DragAndDrop>().valor == 5) { 
            
                modeloDatos.subirRubis_P1();
            }
            
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor == 6)
            {
                modeloDatos.subirRubis_P1();
                modeloDatos.subirRubis_P1();
            }
           
            GameManager.turnoJugador1 = false;
            
        }
        else if (collision.CompareTag("DadoP2"))
        {
            if (collision.gameObject.GetComponent<DragAndDrop>().valor == 5)
            {
                modeloDatos.subirRubis_P2();
            }
            else if (collision.gameObject.GetComponent<DragAndDrop>().valor == 6)
            {
                modeloDatos.subirRubis_P2();
                modeloDatos.subirRubis_P2();
            }
            GameManager.turnoJugador1 = true;
        }
    }

   private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("DadoP1"))
        { 
                if (collision.gameObject.GetComponent<DragAndDrop>().valor == 5)
                {
                    modeloDatos.bajarRubis_P1();
                }
                else if (collision.gameObject.GetComponent<DragAndDrop>().valor == 6)
                {
                    modeloDatos.bajarRubis_P1();
                    modeloDatos.bajarRubis_P1();
                }
            GameManager.turnoJugador1 = true;
        }

        else if (collision.CompareTag("DadoP2"))
        {
                if (collision.gameObject.GetComponent<DragAndDrop>().valor == 5)
                {

                    modeloDatos.bajarRubis_P2();
                }
                else if (collision.gameObject.GetComponent<DragAndDrop>().valor == 6)
                {
                    modeloDatos.bajarRubis_P2();
                    modeloDatos.bajarRubis_P2();
                }
            GameManager.turnoJugador1 = false;
            }
        }

    
}



