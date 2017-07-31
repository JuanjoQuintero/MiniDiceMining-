using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
  
   public Vector2 startPosition;

    public int valor;

    private Animator anim;
    // Use this for initialization
    private void Awake()
    {
        startPosition = new Vector2(transform.position.x, transform.position.y);
        
        //anim = GetComponent<Animator>();
    }


    void Start()
    {
        // anim.SetTrigger("Inicial");

    }

    // Update is called once per frame
    void Update()
    {

        //Codigo para mantener un sprite 2d dentro de los límites de la pantalla
        if (transform.position.x >= 8.2f)
        {
            transform.position = new Vector3(8.2f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -8.2f)
        {
            transform.position = new Vector3(-8.2f, transform.position.y, transform.position.z);
        }

        if (transform.position.y <= -4.4f)
        {
            transform.position = new Vector3(transform.position.x, -4.4f, transform.position.z);
        }
        if (transform.position.y >= 4.4f)
        {
            transform.position = new Vector3(transform.position.x, 4.4f, transform.position.z);
        }



    }


    private void OnMouseDown()
    {
        OnMouseDrag();
    }

    void OnMouseDrag()
    {
        //codigo para arrastar un objeto en funcion de la posicion del raton
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.y);



    }

    // Código para centrar el dado en el espacio reservado, se consigue estableciendo al dado como hijo en el script de puntuación de cada materia.
   /* private void OnMouseUp()
    {
       if (transform.parent != null && ((gameObject.transform.position.x >= transform.parent.position.x - 1.5 && gameObject.transform.position.x <= transform.parent.position.x + 1.5) &&
            (gameObject.transform.position.y >= transform.parent.position.y - 1.5 && gameObject.transform.position.y <= transform.parent.position.y + 1.5)))
                { 
                startPosition = transform.parent.position;
                gameObject.transform.SetPositionAndRotation(startPosition, Quaternion.identity);
       
                }

            else if(transform.parent == null)
            
            {
                gameObject.transform.SetPositionAndRotation(startPosition, Quaternion.identity);
            }
        }
        */


    }



        




