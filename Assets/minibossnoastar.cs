using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minibossnoastar : MonoBehaviour
{
    public int health;


    private Animator anim;
    public Transform enemymove;
    public miniboss boss;
    

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void takedamage(int damge)
    {
        

        boss = GetComponent<miniboss>();
        if (transform.localScale.x == -1f)
            enemymove.position = new Vector2(enemymove.position.x + 0.5f, enemymove.position.y);
        if (transform.localScale.x == 1f)
            enemymove.position = new Vector2(enemymove.position.x - 0.5f, enemymove.position.y);
        anim.SetTrigger("hurt");
        boss.speed = 0;
        

        if (health < 0)
        {
            anim.SetTrigger("die");

        }
        Debug.Log("takedamge");
    }
    public void takedamagefire(int damge)
    {

        anim.SetTrigger("hurt");
        health -= damge;
        if (health <= 0)
        {
            anim.SetTrigger("die");

        }

    }
    public void die()
    {
        Destroy(gameObject);
    }
    public void ngangchuyendong()
    {
        boss.speed = 3;
        
    }
}
