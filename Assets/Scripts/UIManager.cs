using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text P1_rubi;
    public Text P2_rubi;
    public Text P1_zafiros;
    public Text P2_zafiros;
    public Text P1_esme;
    public Text P2_esme;
    public Text P1_oro;
    public Text P2_oro;

    public Text Ganador;

    // Use this for initialization
    void Start () {
        /* P1_rubi.text = GameManager.p1_rubis.ToString();
         P2_rubi.text = GameManager.p2_rubis.ToString();
         P1_zafiros.text = GameManager.p1_zafiros.ToString();
         P2_zafiros.text = GameManager.p2_zafiros.ToString();
         P1_esme.text = GameManager.p1_esmeraldas.ToString();
         P2_esme.text = GameManager.p2_esmeraldas.ToString();
         P1_oro.text = GameManager.p1_oro.ToString();
         P2_oro.text = GameManager.p2_oro.ToString();
         */
        if (GameManager.ganadorP1 && GameManager.esEmpate == false)
        {
            Ganador.text = " El Jugador 1 Gana!!";

        }

        else if (GameManager.ganadorP1 == false)
        {
            Ganador.text = " El Jugador 2 Gana!!";
        }

        else if(GameManager.ganadorP1 && GameManager.esEmpate)
        {
            Ganador.text = " Es empate!";
            GameManager.esEmpate = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
        P1_rubi.text = GameManager.p1_rubis.ToString();
        P2_rubi.text = GameManager.p2_rubis.ToString();
        P1_zafiros.text = GameManager.p1_zafiros.ToString();
        P2_zafiros.text = GameManager.p2_zafiros.ToString();
        P1_esme.text = GameManager.p1_esmeraldas.ToString();
        P2_esme.text = GameManager.p2_esmeraldas.ToString();
        P1_oro.text = GameManager.p1_oro.ToString();
        P2_oro.text = GameManager.p2_oro.ToString();
        
    }

    
}
