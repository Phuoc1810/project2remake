using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class skillblood : MonoBehaviour
{
    public int phantram;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            Enemy enemyheath;
            enemyheath = collision.gameObject.GetComponent<Enemy>();
            enemyheath.takedamage(4);

        }
        else if (collision.CompareTag("enemy2"))
        {

            blood bloodstatus;
            bloodstatus = collision.gameObject.GetComponent<blood>();
            enemynoastar enemyheath;
            enemyheath = collision.gameObject.GetComponent<enemynoastar>();
            enemyheath.takedamage(2);
            bloodstatus.count++;
            if(bloodstatus.count==0)
            bloodstatus.bloodstatus = true;


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
