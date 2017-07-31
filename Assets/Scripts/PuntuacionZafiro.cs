using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntuacionZafiro : MonoBehaviour
{ 
    
    public int bonificacion;
    public bool isAssigned = false;
    private Vector2 centro = new Vector2(0, 0);

    void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("DadoP1")  && !Input.GetMouseButtonDown(0))
        {
           
            collision.gameObject.transform.SetPositionAndRotation(gameObject.transform.position, gameObject.transform.rotation);
          
                  
                        int valorDado = collision.gameObject.GetComponent<DragAndDrop>().valor;
                        if (valorDado + bonificacion >= 5)
                        {
                            GameManager.p1_zafiros++;
                            GameManager.p1_zafiros++;
                        }
                        else if (valorDado + bonificacion == 4 || valorDado + bonificacion == 3)
                        {
                            GameManager.p1_zafiros++;

                         }

                      
                    
                
            
        }


        else if (collision.CompareTag("DadoP2"))
        {
            
            collision.gameObject.transform.SetParent(transform);
            
        
        }
    }

    /*if(){
    int valorDado = collision.gameObject.GetComponent<DragAndDrop>().valor;
                if (valorDado + bonificacion <= 5)
                {
                    GameManager.p1_zafiros++;
                    GameManager.p1_zafiros++;
                }
                else if (valorDado + bonificacion == 4 || valorDado + bonificacion == 3)
                {
                    GameManager.p1_zafiros++;

                }
   
    }*/
    }
 

