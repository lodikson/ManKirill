using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public float chaseRange = 10f;      // Радиус преследования
    public float minStopDistance = 1f;  // Минимальное расстояние для остановки
    public float moveSpeed = 3f;        // Скорость движения
    public float patrolDelay = 2f;      // Задержка перед началом патрулирования

    private Transform target;
    private Transform player;
    private bool isDead = false;
    private bool hasPatrolled = false;
    private float spawnX, spawnY;

    public Rigidbody2D rb;

    void Awake()
    {
        spawnX = transform.position.x;
        spawnY = transform.position.y;
    }

    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        target = GameObject.FindGameObjectWithTag("Player")?.transform;
        Invoke(nameof(StartPatrol), patrolDelay);
    }

    void StartPatrol()
    {
        hasPatrolled = true;
    }

    void Update()
    {
        if (!hasPatrolled || !target || isDead)
            return;

        float dist = Mathf.Abs(target.position.x - transform.position.x);
        if (dist <= chaseRange)
        {
            ChaseTarget();
        }
        
    }

    void ChaseTarget()
    {
        Vector2 player = new Vector2(target.position.x, rb.position.y);
        Vector2 newPosition = Vector2.MoveTowards(rb.position, player, moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(newPosition);


        // Останавливаемся на минимальной дистанции
        if (Mathf.Abs(transform.position.x - target.position.x) <= minStopDistance)
            StopChase();
    }

    void StopChase()
    {
        CancelInvoke(nameof(ChaseTarget));
    }

    public void Die()
    {
        isDead = true;
        Destroy(gameObject);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Получаем состояние текущего врага из хранилища
        if (EnemyDataStorage.instance.HasDataForEnemy(this))
        {
            isDead = EnemyDataStorage.instance.IsEnemyDead(this);
            if (isDead)
                Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Монстр столкнулся с игроком!");
        }
    }
}
