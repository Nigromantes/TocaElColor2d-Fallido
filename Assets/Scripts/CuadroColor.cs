﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class CuadroColor : MonoBehaviour,IPointerDownHandler {

	
    public enum Color {Azul,Rojo,Amarillo};



    public Sprite sprite_Azul;
    public Sprite sprite_Rojo;
    public Sprite sprite_Amarillo;

    public SpriteRenderer spriteRender;
    private int codigoColor;
    
    // Use this for initialization
	void Start () {
        //codigoColor = UnityEngine.Random.Range(1, 4);
        spriteRender = GetComponent<SpriteRenderer>();        
        //justeColor(codigoColor);
       


    }

    public void AjusteColor(int codigoColor)
    {
        switch (codigoColor)
        {
            case 1: spriteRender.sprite = sprite_Azul; break;
            case 2: spriteRender.sprite = sprite_Rojo; break;
            case 3: spriteRender.sprite = sprite_Amarillo; break;
        }

    }

    // Update is called once per frame
    void Update () {
		
	}


    public void OnPointerDown(PointerEventData eventData)
    {
       // Debug.Log("Se ejecuta el cambio de color");

        if (codigoColor < 3)
        {
            codigoColor++;
        }
        else
        {
            codigoColor = 1;
        }
        
        AjusteColor(codigoColor);
    }
}
