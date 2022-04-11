using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SelectorMinijuego : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject prestaAtencion;
    public GameObject minijuego1;
    public GameObject minijuego2;
    public GameObject minijuego3;

    private float tiempo;
    private int numeroAleatrorio;

    System.Random miNumero = new System.Random();

    void Start()
    {
        minijuego1.SetActive(false);
        minijuego2.SetActive(false);
        minijuego3.SetActive(false);
        prestaAtencion.SetActive(true);

        tiempo = 0;
        numeroAleatrorio = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (tiempo != 10)
        {
            tiempo += 1 * Time.deltaTime;
        }

        if (tiempo >= 5 && tiempo != 10)
        {
            numeroAleatrorio = miNumero.Next(1, 4);

            if (numeroAleatrorio == 1)
            {
                minijuego1.SetActive(true);
                prestaAtencion.SetActive(false);
                tiempo = 10; //Para que no vuelva a entrar al if.
            }
            else if (numeroAleatrorio == 2)
            {
                minijuego2.SetActive(true);
                prestaAtencion.SetActive(false);
                tiempo = 10; //Para que no vuelva a entrar al if.
            }
            else if (numeroAleatrorio == 3)
            {
                minijuego3.SetActive(true);
                prestaAtencion.SetActive(false);
                tiempo = 10; //Para que no vuelva a entrar al if.
            }
        }
    }
}
