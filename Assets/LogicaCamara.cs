using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaCamara : MonoBehaviour
{
    public Player player;
    Camera camara;


    void Start()
    {
        camara = GetComponent<Camera>();
    }

    void Update()
    {
        
    }
}
