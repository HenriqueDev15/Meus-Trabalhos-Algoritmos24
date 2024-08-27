using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vector3 = UnityEngine.Vector3;
public class Player : MonoBehaviour
{
    public int velocidade = 10;
    public int forcaPulo = 10;
    public bool noChao = false;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        TryGetComponent(out rb);
    }

    private void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.tag == "Chão")
        {
            noChao = true;
            
        }
    }



    // Update is called once per frame
    void Update()
    {
         Debug.Log("update");
         float x = Input.GetAxis("Horizontal");
         float y = Input.GetAxis("Vertical");

         UnityEngine.Vector3 direcao = new Vector3(x,0,y);
         rb.AddForce(direcao * velocidade * Time.deltaTime, ForceMode.Impulse);
         
         if (Input.GetKeyDown(KeyCode.Space) && noChao)
         {
             rb.AddForce(Vector3.up * forcaPulo, ForceMode.Impulse);
             noChao = false;
         }
         if (transform.position.y < -5) 
         {
             
             SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         }
    }
}
