using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy : Sounds
{

    
    public Animator animator;

    public float speed = 3f;
    public int maxHealth = 100;
    int currentHealth;
    public Transform player;
    private Rigidbody2D rb;
    private Vector2 movement;
    bool movem = true;
    public Transform target;

    public float detectionRadius = 1f; // Радиус обнаружения
    public LayerMask layerMask;       // Слой для фильтрации объектов
    public string targetTag = "Target"; // Тег целевых объектов

    public Transform attackPoint;

    public int DamagePlayer = 10;

    public float attackRate = 6f;
    float nextAttackTime = 0f;
    public float DocTime = 3;
    public float detectionRange = 5f; // Радиус обнаружения игрока
    private bool isPlayerInRange = false; // Флаг для проверки, в пределах ли враг игрока

    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        currentHealth = maxHealth;
        rb = this.GetComponent<Rigidbody2D>();
    }

    void StartChase(GameObject targetObj)
    {
        target = targetObj.transform; // Сохраняем ссылку на цель
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if(currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        animator.SetBool("IsDead", true);

        Debug.Log("жизнь моя жестянка");


        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        this.tag = "Finish";

        gameObject.GetComponent<Loot>().Loots(1);

    }
    /*
    
    private void FixedUpdate()
    {
        if (movem)
        {
            MoveChar(movement, 0);
        }
        
    }

    public void MoveChar(Vector2 direction, int speeds)
    {
        if (speed != 0)
        {

            animator.SetBool("Wal", true);
            speed -= speeds;
        }
        else
        {
            animator.SetBool("Wal", false);

        }
        if (speed != 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        

    }
    */
    

    

    
    


    private void Update()
    {
        if(player != null)
        {
            // Проверяем расстояние до игрока
            if (Vector2.Distance(transform.position, player.position) < detectionRange)
            {
                isPlayerInRange = true;
                animator.SetBool("Wal", true);
            }
            else
            {
                isPlayerInRange = false;
                animator.SetBool("Wal", false);
            }

            // Если игрок в пределах досягаемости, преследуем его
            if (movem)
            {
                if (isPlayerInRange)
                {
                    MoveTowardsPlayer();
                }
            }
            

            if (DocTime > 0)
            {
                // Каждый кадр отнимать прошедшее время последнего кадра
                DocTime -= Time.deltaTime;
            }
            else
            {
                speed = 3;
                DocTime = 3;
            }
            // Проверка пересечения всех объектов с тегом "Target" в круговом радиусе
            Collider2D[] detectedObjects = Physics2D.OverlapCircleAll(transform.position, detectionRadius, layerMask);

            foreach (Collider2D collider in detectedObjects)
            {
                if (collider.CompareTag(targetTag))
                {
                    if (Time.time >= nextAttackTime)
                    {

                        Debug.Log($"Обнаружен объект с тегом {targetTag}: {collider.name}, нанесено: {DamagePlayer}");
                        health.hp -= DamagePlayer;
                        nextAttackTime = Time.time + 1f / attackRate;

                    }

                }
            }
        }
        

        // сдох и всё тут
        if (gameObject.tag == "Finish")
        {
            gameObject.SetActive(false);
        }
    }

    void MoveTowardsPlayer()
    {
        // Получаем позицию врага и игрока
        Vector2 enemyPosition = transform.position;
        Vector2 playerPosition = player.position;

        // Двигаемся только по оси X
        if (enemyPosition.x < playerPosition.x)
        {
            transform.position = new Vector2(enemyPosition.x + speed * Time.deltaTime, enemyPosition.y);
        }
        else if (enemyPosition.x > playerPosition.x)
        {
            transform.position = new Vector2(enemyPosition.x - speed * Time.deltaTime, enemyPosition.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Если враг сталкивается со стеной, он должен остановиться
        if (other.gameObject.CompareTag("Wall"))
        {
            Debug.Log("Мне не похуй " + movem);
            rb.velocity = Vector2.zero;
            movem = false;
            // Логика остановки или изменения направления
            // Например, можно просто не двигаться
        }
        else
        {
            movem = true;
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            rb.velocity = Vector2.zero;
            movem = false;
            // Логика остановки или изменения направления
            // Например, можно просто не двигаться
            Debug.Log("Мне не похуй");
        }
        else if (other.CompareTag("Player")) // Проверяем тег объекта
        {
            Debug.Log("Объект с тегом 'Target' попал в зону!");
            StartChase(other.gameObject);
            
        }
        
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, detectionRadius);
    }

    public void Awake()
    {
        if(SceneManager.GetActiveScene().buildIndex != 10)
            DontDestroyOnLoad(gameObject);
        else
        {
            gameObject.tag = "Finish";
        }
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
    }
    
}
