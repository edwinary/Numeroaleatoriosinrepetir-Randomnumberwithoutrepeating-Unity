using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorSinRepetir : MonoBehaviour
{
 
    public List<int> NombreDeSuLista= new List<int>();
    public int Min;
    public int Max;
    private void Start()
    {
       Max = Max + 1;
        for (int i = Min; i < Max; i++)   
        {
            NombreDeSuLista.Add(i);
        }

        InvokeRepeating("Generar", 2, 2);
                            
    }

    void Generar()
    {
        int index = UnityEngine.Random.Range(0, NombreDeSuLista.Count - 1);
        int G = NombreDeSuLista[index];
        NombreDeSuLista.RemoveAt(index);

        Debug.Log(G);
    }


}

