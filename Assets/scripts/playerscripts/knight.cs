using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knight : MonoBehaviour
{
    public static int kcount;
    public GameObject player;

    public Rigidbody2D rb;
    public float speed = 10f; // �������� ������������
    public Transform attackPoint;
    public LayerMask EnemyLaers;
    public float attackRange = 0.5f;

    public int attackDamage = 50;
    public float rotationAngle = 90f;
    public float rotationSpeed = 100f;
    public bool isThrown = false;
    public GameObject knifePrefab; // ������ �������
    public float throwForce = 10f; // ���� ������

    
    private Vector3 direction; // ����������� ��������

    // ����� ��� ��������� ����������� �������
    public void Initialize(Vector3 direction)
    {
        this.direction = direction.normalized; // ����������� �����������
    }

    void Update()
    {
        // ������� ������ � �������� �����������
        transform.position += direction * speed * Time.deltaTime;
        Destroy(gameObject, 1);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("���� � ������");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, EnemyLaers);
        if (collision.CompareTag("Player"))
        {
            health.hp -= 100;
            Achivments.samyrai = 1;
        }
        else
        {
            foreach (Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<enemy>().TakeDamage(attackDamage);
                //enemy.GetComponent<enemy>().MoveChar(transform.position, 1);

            }
            Destroy(gameObject);
        }
        
    }
    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
