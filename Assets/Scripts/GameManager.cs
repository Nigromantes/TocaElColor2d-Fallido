using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {


    public GameObject[] cuadrosColor;
    public CuadroColor cuadroColorPrueba; 
    
	void Awake () {


        //for (int i = 1; i < 30; i++)
        //{

        //    cuadrosColor[i].GetComponent<CuadroColor>().AjusteColor(2);



        //}

        //cuadrosColor[3].GetComponent<CuadroColor>().AjusteColor(2);

        cuadroColorPrueba = GetComponent<CuadroColor>();
        cuadroColorPrueba.AjusteColor(1); 


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
