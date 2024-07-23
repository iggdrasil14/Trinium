using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeometryForm : MonoBehaviour
{
    public static Transform Player { get; private set; }
    public Parallax[] parallaxLayers;
    public float formJumpHeight;                                // Высота прыжка игрового персонажа;
    public float formSpeed;                                     // Скорость перемещения игрового персонажа;
    public GeometryForm prefabFormTriangle;                     // Префаб, форма - треугольник.
    public GeometryForm prefabFormSquare;                       // Префаб, форма - квадрат.
    public GeometryForm prefabFormCircle;                       // Префаб, форма - круг.
    public ParticleSystem prefabSwitchFormFX;                   // Спецэффект, сопровождающий изменение формы.
    public Rigidbody2D rb;                                      // Ссылка на компонент Rigidbody2D.
    public bool IsGrounded => isGrounded;
    protected bool isCanAttack = false;
    protected bool isGrounded = true;                           // Флаг, проверка нахождения персонажа на земле.
    protected bool isMovmentRight;
    [SerializeField] protected PlayerMovement playerMovement;
    private Trigger _trigger;
   
    // Start is called before the first frame update
    void Start()
    {
        //Saves saves = new Saves();
        //saves.score = 10;
        //Saves.Save(saves);
        //Saves saves = Saves.Load();
        //Debug.Log(saves.score);
        
        GeometryForm.Player = transform;
        rb = GetComponent<Rigidbody2D>();                       // Инициализация Rigidbody2D
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
        Transformation();
        if (_trigger != null && InputManager.Instance.DragAndPullInput)
        {
            _trigger.Execute();
        }
    }
    protected virtual void FixedUpdate()
    {

    }
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
    /// Метод, отвечающий за трансформацию игрового персонажа в другую геометрическую форму.
    /// </summary>
    protected virtual void Transformation()
    {
        // Активация формы - треугольник.
        if (InputManager.Instance.FormTriangleInput == true)
        {
            TransformForm(prefabFormTriangle);
        }

        // Активация формы - квадрат.
        if (InputManager.Instance.FormSquareInput == true)
        {
            TransformForm(prefabFormSquare);
        }

        // Активация формы - круг.
        if (InputManager.Instance.FormCircleInput == true)
        {
            TransformForm(prefabFormCircle);
        }
    }

    /// <summary>
    /// Метод для трансформации формы.
    /// </summary>
    /// <param name="formPrefab">Префаб новой формы</param>
    protected void TransformForm(GeometryForm formPrefab)
    {
        if (formPrefab != null)
        {
            // Уничтожает текущую форму.
            Destroy(gameObject);
            // Активирует спецэффект, сопровождающий изменение формы.
            Instantiate(prefabSwitchFormFX, transform.position, Quaternion.identity);
            // Активирует новую форму.
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
    /// Метод отключения
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
        other.gameObject.TryGetComponent<Trigger>(out _trigger);
    }
    protected virtual void OnTriggerExit2D(Collider2D other)
    {
        _trigger = null;
    }
    private void MoveParallax(int side)
    {
        for (int i = 0; i < parallaxLayers.Length; i++)
        {
            parallaxLayers[i].Move(side);
        }
    }
}
