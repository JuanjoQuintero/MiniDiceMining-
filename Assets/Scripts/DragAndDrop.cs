using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    public Sprite[] imagenCara;
    public Vector2 startPosition;
   
   
    private float limiteVertical = 4.4f;
    private float limiteHorizontal = 8.3f;
    public int puntos = 0;
    public int valor = 0;
    private Animator anim;

    private void Awake()
    {
      
        startPosition = new Vector2(transform.position.x, transform.position.y);
        valor = (int)Random.Range(0, imagenCara.Length) + 1;
        gameObject.GetComponent<SpriteRenderer>().sprite = imagenCara[valor - 1];
    }


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
       

        //Codigo para mantener un sprite 2d dentro de los límites de la pantalla
        if (transform.position.x >= limiteHorizontal)
        {
            transform.position = new Vector3(limiteHorizontal, transform.position.y, transform.position.z);
        }
        else if (transform.position.x <= -limiteHorizontal)
        {
            transform.position = new Vector3(-limiteHorizontal, transform.position.y, transform.position.z);
        }

        if (transform.position.y >= limiteVertical)
        {
            transform.position = new Vector3(transform.position.x, limiteVertical, transform.position.z);
        }
        else if (transform.position.y <= -limiteVertical)
        {
            transform.position = new Vector3(transform.position.x, -limiteVertical, transform.position.z);
        }
 }

   
    private void OnMouseDown()
    {    
        OnMouseDrag();      
    }
     
   void OnMouseDrag()
    {
        //if (GameManager.turnoJugador1 == true && gameObject.CompareTag("DadoP1"))
            EstoEselDrag();
    }

    // Cuando soltamos el dado, vuelve a la posicion establecida, que cambia según el espacio e el que dejamos el dado
    private void OnMouseUp()
        {        
            gameObject.transform.SetPositionAndRotation(startPosition, Quaternion.identity);       
        }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Rubi")
        {

            startPosition = collision.gameObject.transform.position;
            transform.SetPositionAndRotation(collision.transform.position, Quaternion.identity);

        }

        else if (collision.gameObject.tag == "Zafiro")
        {
            startPosition = collision.gameObject.transform.position;
            transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "Esmeralda")
        {
            startPosition = collision.gameObject.transform.position;
            transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "Mercado")
        {
            startPosition = collision.gameObject.transform.position;
            transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rubi" )
        {
         transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }

        else if (collision.gameObject.tag == "Zafiro")
        {
           
            transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }

        else if (collision.gameObject.tag == "Esmeralda")
        {
            
            transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "Mercado")
        {
            
            transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }
        
    }
    public void EstoEselDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.y);
    }
    
}
