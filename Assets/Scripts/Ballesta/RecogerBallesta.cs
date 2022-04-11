using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerBallesta : MonoBehaviour
{
    //Variables
    public GameObject jugador;
    public GameObject ballesta;
    private bool activo = false;
    public GameObject camaraPrincipal;
    public GameObject camaraPrimeraPersona;
    public float cooldownJuego = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DistanciaJugador(jugador, ballesta);
        DuracionJuego();
    }

    //Metodos
    void DistanciaJugador(GameObject jugador, GameObject ballesta)
    {
        //Variable
        float distancia;
        distancia = Vector3.Distance(ballesta.transform.position, jugador.transform.position);
        //letra "E" para recoger ballesta
        if (Input.GetKeyDown(KeyCode.E) && distancia <= 1 && !activo)
        {
            //Cambio variable de control
            activo = !activo;
            //Activo la cámara primera persona
            camaraPrimeraPersona.SetActive(true);
            //Desactivo movimiento del PJ
            jugador.GetComponent<PersonajeCamina>().enabled = false;
            //Activo Juego
            ballesta.GetComponent<SpawnBlanco>().enabled = true;
            //Tiempo límite juego
            cooldownJuego = 10f;
        }
        //letra "X" o "Esc" para salir de la vista
        if ( (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.X)) && activo )
        {
            //Cambio variable de control
            activo = !activo;
            //Desactivo la cámara primera persona
            camaraPrimeraPersona.SetActive(false);
            //Activo movimiento del PJ
            jugador.GetComponent<PersonajeCamina>().enabled = true;
            //Desactivo Juego
            ballesta.GetComponent<SpawnBlanco>().enabled = false;
        }
    }
    void DuracionJuego()
    {
        if (cooldownJuego < 0)
        {
            //Termina el juego, prendo cámara jugador, desactivo juego y activo movimiento
            //Cambio variable de control de corresponder
            if ( activo )
            {
                activo = !activo;
            }
            //Desactivo la cámara primera persona
            camaraPrimeraPersona.SetActive(false);
            //Activo movimiento del PJ
            jugador.GetComponent<PersonajeCamina>().enabled = true;
            //Desactivo Juego
            ballesta.GetComponent<SpawnBlanco>().enabled = false;
        }
        else
        {
            cooldownJuego -= Time.deltaTime;
        }
    }
}
