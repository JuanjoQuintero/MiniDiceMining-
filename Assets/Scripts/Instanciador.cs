using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciador : MonoBehaviour {

    public GameObject[] dado;


	// Use this for initialization
	void Start () {
        Instantiate(dado[Random.Range(0, dado.Length)],transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
