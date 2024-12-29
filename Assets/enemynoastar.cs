using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemynoastar : MonoBehaviour
{
    public float health;

 
    private Animator anim;
    public Transform enemymove;
  
    public enemyfollow enemy;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void takedamage(float damge)
    {
        enemy = GetComponent<enemyfollow>();
        
       
        if (transform.localScale.x == -1f)
            enemymove.position = new Vector2(enemymove.position.x + 0.5f, enemymove.position.y);
        if (transform.localScale.x == 1f)
            enemymove.position = new Vector2(enemymove.position.x - 0.5f, enemymove.position.y);
        anim.SetTrigger("hurt");
        health -= damge;
        enemy.speed = 0;
        
        if (health < 0)
        {
            anim.SetTrigger("die");

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
      
        enemy.speed = 2;
    }
}
