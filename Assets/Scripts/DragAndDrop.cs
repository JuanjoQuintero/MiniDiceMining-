using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragAndDrop : MonoBehaviour
{
    public Sprite[] imagenCara;
    public Vector2 startPosition;
    public Vector2 huecoDado;
    public EstoEsEldragç dragDados;
    public bool sePuedeMover = false;
   

    private float limiteVertical = 4.4f;
    private float limiteHorizontal = 8.3f;
    public int puntos = 0;
    public int valor = 0;

    private void Awake()
    {
        huecoDado = new Vector2(transform.position.x, transform.position.y);
        startPosition = new Vector2(transform.position.x, transform.position.y);
        valor = (int)Random.Range(0, imagenCara.Length) + 1;
        gameObject.GetComponent<SpriteRenderer>().sprite = imagenCara[valor - 1];
    }


    void Start()
    {
        

    }

    // Update is called once per frame
    void Update() { 


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

   
    public void OnMouseDown()
    {
        if (transform.tag == "DadoP1" && GameManager.turnoJugador1)
        {
            sePuedeMover = true;
        }
        else if (transform.tag == "DadoP2" && GameManager.turnoJugador1 == false)
        {
            sePuedeMover = true;
        }
    }

   public void OnMouseDrag()
    {
        if(sePuedeMover)
        EstoEselDrag();
    }

    

    // Cuando soltamos el dado, vuelve a la posicion establecida, que cambia según el espacio e el que dejamos el dado
    public void OnMouseUp()
    {

        transform.SetPositionAndRotation(huecoDado, Quaternion.identity);
        sePuedeMover = false;
        

    }
   
   

        private void OnTriggerEnter2D(Collider2D collision)
        {
        

        if (collision.gameObject.tag == "Rubi")
        {
            huecoDado = collision.gameObject.transform.position;
            if (collision.GetComponent<PuntuacionRubi>().hayDado == true)
            {
                huecoDado = startPosition;
            }
            
            transform.SetPositionAndRotation(huecoDado, Quaternion.identity);
            
        }

        else if (collision.gameObject.tag == "Zafiro" || collision.gameObject.tag == "Zafiro2")
        {
           huecoDado = collision.gameObject.transform.position;
            if (collision.GetComponent<PuntuacionZafiro>().hayDado == true)
            {
                huecoDado = startPosition;
            }

            transform.SetPositionAndRotation(huecoDado, Quaternion.identity);
           
        }
        else if (collision.gameObject.tag == "Esmeralda")
        {
            huecoDado = collision.gameObject.transform.position;
            if (collision.GetComponent<PuntuacionEsmeralda>().hayDado == true)
            {
                huecoDado = startPosition;
            }

            transform.SetPositionAndRotation(huecoDado, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "Mercado")
        {
            huecoDado = collision.gameObject.transform.position;
            if (collision.GetComponent<Mercado>().hayDado == true)
            {
                huecoDado = startPosition;
            }
            transform.SetPositionAndRotation(huecoDado, Quaternion.identity);
        }
    }
    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Rubi" )
        {
            huecoDado = startPosition;
           // transform.SetPositionAndRotation(startPosition, Quaternion.identity);
         
        }

        else if (collision.gameObject.tag == "Zafiro")
        {
            huecoDado = startPosition;
            //transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }

        else if (collision.gameObject.tag == "Esmeralda")
        {
            huecoDado = startPosition;
            //transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }
        else if (collision.gameObject.tag == "Mercado")
        {
            huecoDado = startPosition;
            //transform.SetPositionAndRotation(startPosition, Quaternion.identity);
        }
        
    }
    public void EstoEselDrag()
    {
        float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
        transform.position = new Vector3(pos_move.x, pos_move.y, transform.position.y);
    }

   
    
}
