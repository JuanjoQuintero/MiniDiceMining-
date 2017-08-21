using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeloDatos : MonoBehaviour
{

    //Metodos para subir las materias en el marcador

    public void subirRubis_P1()
    {
        GameManager.p1_rubis++;
    }

    public void subirRubis_P2()
    {
        GameManager.p2_rubis++;
    }

    public void subirZafiro_P1()
    {
        GameManager.p1_zafiros++;
    }

    public void subirZafiro_P2()
    {
        GameManager.p2_zafiros++;
    }

    public void subirEsmeralda_P1()
    {
        GameManager.p1_esmeraldas++;
    }

    public void subirEsmeralda_P2()
    {
        GameManager.p2_esmeraldas++;
    }


    public void subirOro_P1()
    {
        GameManager.p1_oro++;
    }

    public void subirOro_P2()
    {
        GameManager.p2_oro++;
    }


    //Metodos para bajar materias primas en el marcador

    public void bajarRubis_P1()
    {
        GameManager.p1_rubis--;
    }

    public void bajarRubis_P2()
    {
        GameManager.p2_rubis--;
    }

    public void bajarZafiro_P1()
    {
        GameManager.p1_zafiros--;
    }

    public void bajarZafiro_P2()
    {
        GameManager.p2_zafiros--;
    }

    public void bajarEsmeralda_P1()
    {
        GameManager.p1_esmeraldas--;
    }

    public void bajarEsmeralda_P2()
    {
        GameManager.p2_esmeraldas--;
    }


    public void bajarOro_P1()
    {
        GameManager.p1_oro--;
    }

    public void bajarOro_P2()
    {
        GameManager.p2_oro--;
    }


    public int getRubi_P1()
    {
        return GameManager.p1_rubis;
    }

    public int getRubi_P2()
    {
        return GameManager.p2_rubis;
    }

    public int getZafiro_P1()
    {
        return GameManager.p1_zafiros;
    }

    public int getZafiro_P2()
    {
        return GameManager.p2_zafiros;
    }

    public int getEsmeralda_P1()
    {
        return GameManager.p1_esmeraldas;
    }

    public int getEsmeralda_P2()
    {
        return GameManager.p2_esmeraldas;
    }

    public int getOro_P1()
    {
        return GameManager.p1_oro;
    }

    public int getOro_P2()
    {
        return GameManager.p2_oro;
    }
}
