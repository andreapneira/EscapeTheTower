using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeCamina : MonoBehaviour
{
    public int movementCharacterSpeed;
    public int rotateCharacterSpeed;
    public Animator animacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoverPersonaje();
    }
    //Metodos
    void MoverPersonaje()
    {
        //Mover y rotar personaje
        transform.Rotate(new Vector3(0, 1, 0) * rotateCharacterSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
        transform.position += transform.forward * movementCharacterSpeed * Input.GetAxisRaw("Vertical") * Time.deltaTime;
        //Activar o desactivar animación
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            //Jugador caminando
            animacion.SetBool("EstaCorriendo", true);
        }
        else
        {
            //Jugador quieto
            animacion.SetBool("EstaCorriendo", false);
        }
    }
}
