using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : Sounds
{
    public Animator animator;
    public Transform attackPoint;
    public LayerMask EnemyLaers;

    public float attackRange = 0.5f;
    public int attackDamage = 20;

    public float attackRate = 2f;
    float nextAttackTime = 0f; 

    private void Start()
    {
       
    }

    void Update()
    {
        LookAtMouse();

        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    
    private void LookAtMouse()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //transform.up = (mousePos - new Vector2(transform.position.x, transform.position.y));
    }
    
    
    void Attack()
    {
        
        //Play attack animation
        animator.SetTrigger("Melee");
        // Detected enemies in range of attack
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, EnemyLaers);
        // Damage them
        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<enemy>().TakeDamage(attackDamage);
            //enemy.GetComponent<enemy>().MoveChar(transform.position, 1);
        }
        //musik
        //PlaySounds(sounds[0]);
        
        
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
