using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class hitskill : MonoBehaviour
{
    public int phantram;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("miniboss"))
        {
           
            phantram = Random.Range(1, 10);
            burn burnfire;
            burnfire = collision.gameObject.GetComponent<burn>();
            minibossnoastar minibossheath;
            minibossheath = collision.gameObject.GetComponent<minibossnoastar>();
            minibossheath.takedamage(2);
            if (phantram == 1 || phantram == 2 || phantram == 3 || phantram == 4)
                burnfire.chay = true;
        }
        if (collision.CompareTag("enemy2"))
        {
            phantram = Random.Range(1, 10);
            burn burnfire;
            burnfire = collision.gameObject.GetComponent<burn>();
            enemynoastar enemyheath;
            enemyheath = collision.gameObject.GetComponent<enemynoastar>();
            enemyheath.takedamage(2);
            if (phantram == 1 || phantram == 2 || phantram == 3 || phantram == 4)
                burnfire.chay = true;
            

        }
        //tan cong boss 
        if (collision.CompareTag("Boss"))
        {
            BossController boss = collision.GetComponent<BossController>();
            if (boss != null)
            {
                boss.TakeDamage(); //Goi ham take damage
            }
        }
    }
}
