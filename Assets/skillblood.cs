using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class skillblood : MonoBehaviour
{
    public int phantram;
    public playersat damgeskill;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("miniboss"))
        {
            
            blood bloodstatus;
            bloodstatus = collision.gameObject.GetComponent<blood>();
            minibossnoastar minibossheath;
            minibossheath = collision.gameObject.GetComponent<minibossnoastar>();
            minibossheath.takedamage(damgeskill.skill);
            bloodstatus.count++;
            if (bloodstatus.count <= 5)
                bloodstatus.bloodstatus = true;
        }
        if (collision.CompareTag("enemy2"))
        {

            blood bloodstatus;
            bloodstatus = collision.gameObject.GetComponent<blood>();
            enemynoastar enemyheath;
            enemyheath = collision.gameObject.GetComponent<enemynoastar>();
            enemyheath.takedamage(damgeskill.skill);
            bloodstatus.count++;
            if(bloodstatus.count<=5)
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
