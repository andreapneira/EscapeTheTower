using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeCamina : MonoBehaviour
{
    public int movementCharacterSpeed;
    public int rotateCharacterSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * rotateCharacterSpeed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);

        transform.position += transform.forward * movementCharacterSpeed * Input.GetAxisRaw("Vertical") * Time.deltaTime;
    }
}
