using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionEsmeralda : MonoBehaviour
{
    public int bonificacion;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DadoP1"))
        {
            Debug.Log("me ha dado");
            collision.gameObject.transform.SetParent(transform);

            int valorDado = collision.gameObject.GetComponent<DragAndDrop>().valor;
            if (valorDado + bonificacion == 6)
            {
                GameManager.p1_esmeraldas++;
                GameManager.p1_esmeraldas++;
                GameManager.p1_esmeraldas++;
            }
            else if (valorDado + bonificacion == 4 || valorDado + bonificacion == 3 || valorDado == 5)
            {
                GameManager.p1_esmeraldas++;
                GameManager.p1_esmeraldas++;
            }
            else if (valorDado + bonificacion <= 2)
            {
                GameManager.p1_esmeraldas++;
            }
        }


        else if (collision.CompareTag("DadoP2"))
        {
            collision.gameObject.transform.SetParent(transform);
            //collision.gameObject.transform.position = new Vector2(0, 0);
            int valorDado = collision.gameObject.GetComponent<DragAndDrop>().valor;
            if (valorDado + bonificacion >= 6)
            {
                GameManager.p2_esmeraldas++;
                GameManager.p2_esmeraldas++;
            }
            else if (valorDado + bonificacion == 3 || valorDado + bonificacion == 4 || valorDado + bonificacion == 5) 
            {
                GameManager.p2_esmeraldas++;
                GameManager.p2_esmeraldas++;

            }
            else if(valorDado + bonificacion <= 2)
            {
                GameManager.p2_esmeraldas++;
            }
        }
    }
}
