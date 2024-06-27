using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeometryForm : MonoBehaviour
{
    public static Transform Player { get; private set; }
    public Parallax[] parallaxLayers;
    public float formJumpHeight;                                // ������ ������ �������� ���������;
    public float formSpeed;                                     // �������� ����������� �������� ���������;
    [SerializeField] protected PlayerMovement playerMovement;
    public GeometryForm prefabFormTriangle;                     // ������, ����� - �����������.
    public GeometryForm prefabFormSquare;                       // ������, ����� - �������.
    public GeometryForm prefabFormCircle;                       // ������, ����� - ����.
    public ParticleSystem prefabSwitchFormFX;                   // ����������, �������������� ��������� �����.
    public Rigidbody2D rb;                                      // ������ �� ��������� Rigidbody2D.
    protected bool isCanAttack = false;
    protected bool isGrounded = true;                           // ����, �������� ���������� ��������� �� �����.
    protected bool isMovmentRight;

    public bool IsGrounded => isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        GeometryForm.Player = transform;
        rb = GetComponent<Rigidbody2D>();                       // ������������� Rigidbody2D
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D not found on " + gameObject.name);
        }
        FindObjectOfType<ManagerMainCamera>().target = transform;
        parallaxLayers = FindObjectsOfType<Parallax>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        //Movement();
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Jump();
        //}
        Transformation();
    }

    /// <summary>
    /// �����, ���������� �� ������������ �������� ���������.
    /// </summary>
    protected virtual void Movement()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = 0;
        // ����������� ������.
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            velocity.x = formSpeed;
            isMovmentRight = true;
            MoveParallax(-1);
        }
        // ����������� �����.
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            velocity.x = -formSpeed;
            isMovmentRight = false;
            MoveParallax(1);
        }
        rb.velocity = velocity;
    }

    /// <summary>
    /// �����, ���������� �� ������ �������� ���������.
    /// </summary>
    protected virtual void Jump()
    {
        if (isGrounded == false)
        {
            return;
        }
        Vector2 jumpDirection = new Vector2(0, formJumpHeight);
        rb.AddForce(jumpDirection, ForceMode2D.Impulse);
    }

    /// <summary>
    /// �����, ���������� �� ������������� �������� ��������� � ������ �������������� �����.
    /// </summary>
    protected virtual void Transformation()
    {
        // ��������� ����� - �����������.
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            TransformForm(prefabFormTriangle);
        }

        // ��������� ����� - �������.
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            TransformForm(prefabFormSquare);
        }

        // ��������� ����� - ����.
        if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            TransformForm(prefabFormCircle);
        }
    }

    /// <summary>
    /// ����� ��� ������������� �����.
    /// </summary>
    /// <param name="formPrefab">������ ����� �����</param>
    protected void TransformForm(GeometryForm formPrefab)
    {
        if (formPrefab != null)
        {
            // ���������� ������� �����.
            Destroy(gameObject);
            // ���������� ����������, �������������� ��������� �����.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // ���������� ����� �����.
            Instantiate(formPrefab, transform.position, Quaternion.identity);
        }
        else
        {
            Debug.LogError("The form prefab is null. Please assign the prefab in the inspector.");
        }
    }

    public virtual void Attack()
    {
        isCanAttack = true;
    }
    /// <summary>
    /// ����� ����������
    /// </summary>
    public void AttackComplet()
    {
        isCanAttack = false;
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        if (collision.gameObject.tag == "Platform")
        {
            transform.SetParent(collision.transform);
        }
        if(isCanAttack == true && collision.gameObject.TryGetComponent<Enemy>(out Enemy enemy))
        {
            isCanAttack = false;
            enemy.Damage();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        if (collision.gameObject.tag == "Platform")
        {
            transform.SetParent(null);
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "DeathZone")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void MoveParallax(int side)
    {
        for (int i = 0; i < parallaxLayers.Length; i++)
        {
            parallaxLayers[i].Move(side);
        }
    }
}
