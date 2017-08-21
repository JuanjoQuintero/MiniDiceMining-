using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnoJugador : MonoBehaviour {

    public GameObject flechaJugador1;
    public GameObject flechaJugador2;

    private void Update()
    {
        if (GameManager.turnoJugador1)
        {
            flechaJugador2.SetActive(false);
            flechaJugador1.SetActive(true);    
        }
        else if (GameManager.turnoJugador1 == false)
        {
            flechaJugador1.SetActive(false);
            flechaJugador2.SetActive(true);
        }
    }


}
