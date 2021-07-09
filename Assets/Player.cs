using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] private float velocidad;
    [SerializeField] private float impulso;
    [SerializeField] private float detectarPiso;
    private Vector2 direccionDeInput;
    Transform jugador;
    Rigidbody2D rb;
    int saltosEchos;
    int limiteDeSaltos = 1;
    bool tocaSuelo;
    public Transform groundCheck;
    public LayerMask groundLayer;

    void Start()
    {
        jugador = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();

    }

    public void OnMoverse(InputValue valor)
    {
        direccionDeInput = (Vector2)valor.Get();
    }

    private void Update()
    {
        Mover();
    }

    private void FixedUpdate()
    {
        tocaSuelo = Physics2D.OverlapCircle(groundCheck.position, detectarPiso, groundLayer);
    }

    private void Mover()
    {
        jugador.Translate(Vector3.right * this.direccionDeInput.x * Time.deltaTime * this.velocidad, Space.Self);



    }

    private void OnSalto()
    {
        if (tocaSuelo)
        {
            rb.AddForce(new Vector2(0f, impulso), ForceMode2D.Impulse);
            
        }

    }

   
}