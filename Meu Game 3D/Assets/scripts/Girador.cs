using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girador : MonoBehaviour
{
    public int velocidadeGiro = 5;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up* velocidadeGiro * Time.deltaTime, Space.World);
    }
}
