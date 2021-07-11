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
    [SerializeField] private float detectarPared;
    private Vector2 direccionDeInput;
    Transform jugador;
    Rigidbody2D rb;
    bool tocaParedDerecha;
    bool tocaParedIzquierda;
    bool tocaSuelo;
    bool tocaSueloP;
    bool wallJumping;
    float tocaParedDerechaOIzquierda;


    public Transform groundCheck;
    public Transform paredDerechaCheck;
    public Transform paredIzquierdaCheck;
    public LayerMask groundLayer;
    public LayerMask paredLayer;
    

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
        WallJumping();
    }

    private void FixedUpdate()
    {
        tocaSuelo = Physics2D.OverlapCircle(groundCheck.position, detectarPiso, groundLayer);
        tocaSueloP = Physics2D.OverlapCircle(groundCheck.position, detectarPiso, paredLayer);
        tocaParedDerecha = Physics2D.OverlapCircle(paredDerechaCheck.position, detectarPared, paredLayer);
        tocaParedIzquierda = Physics2D.OverlapCircle(paredIzquierdaCheck.position, detectarPared, paredLayer);
    }

    private void Mover()
    {
       
        
        jugador.Translate(Vector3.right * this.direccionDeInput.x * Time.deltaTime * this.velocidad, Space.Self);
         
    

 
    }

    private void OnSalto()
    {
        if (tocaSuelo || tocaSueloP && !tocaParedDerecha && !tocaParedIzquierda)
        {
            rb.AddForce(new Vector2(0f, impulso), ForceMode2D.Impulse);
            
        }
       
        if (tocaParedDerecha && !tocaSuelo)
        {
            tocaParedDerechaOIzquierda = -3;
            wallJumping = true;
            
        }

        if (tocaParedIzquierda && !tocaSuelo)
        {
            tocaParedDerechaOIzquierda = 3;
            wallJumping = true;
        }
    }

    private void  WallJumping()
    {
      if (wallJumping)
        {
            rb.velocity = new Vector2(velocidad * tocaParedDerechaOIzquierda, impulso);
            Invoke("DesactivarWallJumping", 0.1f);
        }
    }

   
    void DesactivarWallJumping()
    {
        rb.constraints = RigidbodyConstraints2D.FreezePositionX;
        rb.constraints = RigidbodyConstraints2D.None;
        wallJumping = false;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}