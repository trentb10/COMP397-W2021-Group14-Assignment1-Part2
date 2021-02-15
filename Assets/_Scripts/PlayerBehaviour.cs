using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{

    public float playerSpeed = 2.0f;
    public float playerRotationSpeed = 100.0f;
    


    // Update is called once per frame
    void Update()
    {
    

        float x = Input.GetAxis("Horizontal") * playerRotationSpeed * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        transform.Translate(0, 0, z);
        transform.Rotate(0, x, 0);
    }


}
