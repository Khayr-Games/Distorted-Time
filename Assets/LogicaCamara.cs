using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCamara : MonoBehaviour
{
    public Player player;
    public float maximoY;
    public float minimoY;
    private Vector3 posicionRelativa;
    Camera camara;
    Transform posicion;

    void Start()
    {
        camara = GetComponent<Camera>();
        posicion = GetComponent<Transform>();
        posicionRelativa = transform.position - player.transform.position;

    }

    void Update()
    {        
        MoverCamara();
        ClampearCamara();
    }


   void MoverCamara()
    {   
        if (posicion.position.y > -4 && posicion.position.y < 36)
        {   
         transform.position = player.transform.position + posicionRelativa;   
        }
              
    }

    void ClampearCamara()
    {
         posicion.position = new Vector3(posicion.position.x, Mathf.Clamp(posicion.position.y, minimoY, maximoY), posicion.position.z);   
    }
}
