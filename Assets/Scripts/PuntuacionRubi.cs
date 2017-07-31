using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionRubi : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("DadoP1") )
              {
            Debug.Log("me ha dado");
            collision.gameObject.transform.SetParent(gameObject.transform);

            int valorDado = collision.gameObject.GetComponent<DragAndDrop>().valor;
            if (valorDado == 6)
            {
                GameManager.p1_rubis++;
                GameManager.p1_rubis++;
            }
            else if (valorDado == 5)
            {
                GameManager.p1_rubis++;

            }
        }


        else if (collision.CompareTag("DadoP2"))
        {
            collision.gameObject.transform.SetParent(gameObject.transform);
            //collision.gameObject.transform.position = new Vector2(0, 0);
            int valorDado = collision.gameObject.GetComponent<DragAndDrop>().valor;
            if (valorDado == 6)
            {
                GameManager.p2_rubis++;
                GameManager.p2_rubis++;
            }
            else if (valorDado == 5)
            {
                GameManager.p2_rubis++;

            }
        }
    }
}
