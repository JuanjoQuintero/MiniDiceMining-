using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GestorBotones : MonoBehaviour {
   
    public AudioSource gestorSonido;
    public AudioSource boton;
  
    public GameObject altavozOn;
    public GameObject altavozOff;

    public void Awake()
    {
        

        if (GameManager.musica == true)
            {

            gestorSonido.Play();
            altavozOn.SetActive(true);
            altavozOff.SetActive(false);

            }
            else if (GameManager.musica == false)
            {
                gestorSonido.Stop();
                altavozOff.SetActive(true);
                altavozOn.SetActive(false);              
            }
    }

    public void PantallaPrincipal()
    {
        GameManager.resolverDados = false;
        SceneManager.LoadScene("Juego");
     }

    public void ToAbout()
    {
        SceneManager.LoadScene("About");
    }

    public void ToPantallaInicial()
    {
        SceneManager.LoadScene("Pantalla Inicio");
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }

    public void JuegoTerminadoVolverInicio()
    {
        GameManager.p1_esmeraldas = 0;
        GameManager.p1_zafiros = 0;
        GameManager.p1_rubis = 0;
        GameManager.p1_oro = 0;
        GameManager.p2_esmeraldas = 0;
        GameManager.p2_zafiros = 0;
        GameManager.p2_rubis = 0;
        GameManager.p2_oro = 0;     
    }

   

    public void MusicaSioNo()
    {
        
        if(GameManager.musica == true)
        {
            gestorSonido.Stop();
            altavozOn.SetActive(false);
            altavozOff.SetActive(true);

            GameManager.musica = false;     
        }
        else if(GameManager.musica == false)
        {
            gestorSonido.Play();
            altavozOff.SetActive(false);
            altavozOn.SetActive(true);
            
            GameManager.musica = true;
        }
        
    }

    public void QuienEsGanador()
    {
        if(GameManager.p1_oro == 11 && GameManager.p1_oro >GameManager.p2_oro)   
        {
            GameManager.ganadorP1 = true;
            SceneManager.LoadScene("Victoria");
        }
        else if (GameManager.p2_oro == 11 && GameManager.p2_oro > GameManager.p1_oro)
        {
            GameManager.ganadorP1 = false;
            SceneManager.LoadScene("Victoria");
        }
        else if(GameManager.p1_oro == GameManager.p2_oro && GameManager.p1_oro >= 11 || GameManager.p2_oro >=11)
        {
            if(GameManager.p1_oro*4 + GameManager.p1_zafiros*2 + GameManager.p1_esmeraldas > GameManager.p2_oro * 4 + GameManager.p2_zafiros * 2 + GameManager.p2_esmeraldas)
            {
                GameManager.ganadorP1 = true;
                SceneManager.LoadScene("Victoria");
            }
            else if(GameManager.p1_oro * 4 + GameManager.p1_zafiros * 2 + GameManager.p1_esmeraldas < GameManager.p2_oro * 4 + GameManager.p2_zafiros * 2 + GameManager.p2_esmeraldas)
            {
                GameManager.ganadorP1 = true;
                SceneManager.LoadScene("Victoria");
            }
            else if(GameManager.p1_oro * 4 + GameManager.p1_zafiros * 2 + GameManager.p1_esmeraldas == GameManager.p2_oro * 4 + GameManager.p2_zafiros * 2 + GameManager.p2_esmeraldas)
            {
                GameManager.esEmpate = true;
                GameManager.ganadorP1 = true;
                SceneManager.LoadScene("Victoria");
            
            }
        }
        else
        {
            PantallaPrincipal();
            GameManager.turnoJugador1 = !GameManager.turnoJugador1;
        }
       
    }
    
    public void CobrarOroMercado()
    {
        GameManager.resolverDados = true;
    }

    public void SonidoBoton()
    {
        boton.Play();
    }
}
