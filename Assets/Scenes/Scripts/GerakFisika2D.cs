using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class GerakFisika2D : MonoBehaviour
{
    [SerializeField] private float kecepatan = 5f;
    [SerializeField] private float kekuatanLompat = 10f;
    [SerializeField] private float jarakGroundCheck = 0.1f;
    [SerializeField] private LayerMask layerGround;
    [SerializeField] private Transform groundCheck;

    private Rigidbody2D rb;
    private float inputHorizontal;
    private bool isGrounded;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        if (groundCheck == null)
        {
            Debug.LogWarning("groundCheck belum diset. Silakan buat child transform untuk ground check.", this);
        }
    }

    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Lompat();
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck ? groundCheck.position : transform.position, jarakGroundCheck, layerGround);
        var currentVel = rb.linearVelocity;
        currentVel.x = inputHorizontal * kecepatan;
        rb.linearVelocity = currentVel;
    }

    void Lompat()
    {
        rb.AddForce(Vector2.up * kekuatanLompat, ForceMode2D.Impulse);
    }

    void OnDrawGizmosSelected()
    {
        if (groundCheck != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(groundCheck.position, jarakGroundCheck);
        }
    }
}