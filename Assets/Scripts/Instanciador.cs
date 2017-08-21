using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour {

    public GameObject dado;


	// Use this for initialization
	void Awake () {
        GeneraDados();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GeneraDados()
    {
        Instantiate(dado, transform.position, Quaternion.identity);
    }
}
