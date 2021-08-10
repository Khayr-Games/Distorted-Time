using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInput playerInput;
    [SerializeField] public float velocidad;
    [SerializeField] private float impulso;
    [SerializeField] private float detectarPiso;
    [SerializeField] private float detectarPared;
    [SerializeField] private GameObject bala;
    private Vector2 direccionDeInput;
    Transform jugador;
    Rigidbody2D rb;
    bool tocaParedDerecha;
    bool tocaParedIzquierda;
    bool tocaSuelo;
    bool tocaSueloP;
    bool wallJumping;
    bool deslizar;
    float tocaParedDerechaOIzquierda;
    public Vector3 worldPosition;
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
        Deslizar();
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

    private void WallJumping()
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


    public void OnDisparo(InputValue value)
    {
        GameObject nuevaBala;
        if ((float)value.Get() == 1f)
        {
            nuevaBala = Instantiate(bala, jugador.position, jugador.rotation);
        }

    }

    void Deslizar()
    {
        if (tocaParedDerecha && !tocaSuelo)
        {
            deslizar = true;
        }

        if (tocaParedIzquierda && !tocaSuelo)
        {
            deslizar = true;
        }

        if (!tocaParedDerecha && !tocaParedIzquierda)
        {
            deslizar = false;
            
        }

        if (deslizar)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -4f,float.MaxValue));
        }

    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("lal"))
        {

            SceneManager.LoadScene("Nivel");


        }

    }

}