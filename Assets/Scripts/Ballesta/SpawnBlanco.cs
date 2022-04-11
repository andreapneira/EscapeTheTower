using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlanco : MonoBehaviour
{
    //Variables
    public GameObject prefabBlanco;
    public float cooldownBlanco;
    public float temporizadorBlanco = 2f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Spawn(prefabBlanco);
    }
    //Metodos
    void Spawn(GameObject prefab)
    {
        /*
        * x = 1.784 a -1.657
        * y = 0.6003581 a 2.394 
        * z = -14.85 a -6.268
        */
        //Ubicación aleatoria
        Vector3 posicion = new Vector3( Random.Range(1.784f, -1.657f), Random.Range(0.6003581f, 2.394f), Random.Range(-14.85f, -6.268f));
        //Spawn
        if (cooldownBlanco < 0)
        {
            Instantiate(prefab, posicion, Quaternion.identity);
            cooldownBlanco = temporizadorBlanco;
        }
        else
        {
            cooldownBlanco -= Time.deltaTime;
        };
    }
}
