using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceManagement : MonoBehaviour {

    Image dadoP1;
    public Sprite[] imagenCara;
    
    

    private void Awake()
    {   
       
        dadoP1.sprite = imagenCara[Random.Range(0, 6)];
    }
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
    }
