using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    public int maxHealth = 100;
    public static  int currentHealth;
    public HealthBar healthBar;
    bool isDead;


    
    public Camera cam;

    Vector2 movement;
    Vector2 mousePos;

    // Update is called once per frame
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHp(maxHealth);
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


        // if(Input.GetKeyDown(KeyCode.Space))
        //{
        //TakeDamage(20);
        // print("hit");
        //}
    }

    
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }



    //  void heal (int heal)
    // {
    //currentHealth += heal;
    // if (currentHealth > 0) heal = maxHealth;

    //}

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);


        if (currentHealth <= 0 && !isDead)
        {
            Destroy(gameObject);
            Dead();
        }

    }
    void Dead()
    {
        isDead = true;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet1")
        {
           
                TakeDamage(10);
               
                //print("-10");
            
        }
        if (other.tag == "BomberBot")
        {
            TakeDamage(50);
               
             // print("-50");
           
        }


    }

}
