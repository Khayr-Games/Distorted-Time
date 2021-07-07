
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float velocidad;
    [SerializeField] private float impulso;
    private Vector2 direccionDeInput;
    Transform jugador;
    Rigidbody2D rb;
    int saltosEchos;
    int limiteDeSaltos = 1;
    void Start()
    {
        jugador = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();

    }
    public void OnMoverse (InputValue valor)
    {
       direccionDeInput = (Vector2)valor.Get();
    }
    private void Update()
    {
        Mover();
    }
    private void Mover()
    {
        jugador.Translate(Vector3.right * this.direccionDeInput.x * Time.deltaTime * this.velocidad, Space.Self);
        
     
        
    }
    private void OnSalto()
    {
        if (saltosEchos < limiteDeSaltos)
        {
            rb.AddForce(new Vector2(0f, impulso), ForceMode2D.Impulse);
            saltosEchos++;
        }
       
    }
    void OnCollisionEnter2D(Collision2D obj)
    {
        if (obj.collider.tag == "suelo")
        {
            saltosEchos = 0;
        }
    }
}
