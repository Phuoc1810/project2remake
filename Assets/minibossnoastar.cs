using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minibossnoastar : MonoBehaviour
{
    public float health;


    private Animator anim;
    public Transform enemymove;
    public miniboss boss;
    
    public GameObject chest;
    public GameObject wall;
    private void Start()
    {
        anim = GetComponent<Animator>();
        chest.SetActive(false);
        wall.SetActive(true);
    }

    public void takedamage(float damge)
    {
        

        boss = GetComponent<miniboss>();
        if (transform.localScale.x == -1f)
            enemymove.position = new Vector2(enemymove.position.x + 0.5f, enemymove.position.y);
        if (transform.localScale.x == 1f)
            enemymove.position = new Vector2(enemymove.position.x - 0.5f, enemymove.position.y);
        anim.SetTrigger("hurt");
        health -= damge;
        boss.speed = 0;
        

        if (health < 0)
        {
            anim.SetTrigger("die");
            chest.SetActive(true);
            wall.SetActive(false);
        }
        Debug.Log("takedamge");
    }
    public void takedamagefire(float damge)
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
