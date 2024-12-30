using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class skillblood : MonoBehaviour
{
    public playersat damge;
    public int phantram;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("miniboss"))
        {
            
            bloodminiboss bloodstatus;
            bloodstatus = collision.gameObject.GetComponent<bloodminiboss>();
            minibossnoastar minibossheath;
            minibossheath = collision.gameObject.GetComponent<minibossnoastar>();
            minibossheath.takedamage(damge.skill);
            bloodstatus.count++;
            
                bloodstatus.bloodstatus = true;
        }
        if (collision.CompareTag("enemy2"))
        {

            blood bloodstatus;
            bloodstatus = collision.gameObject.GetComponent<blood>();
            enemynoastar enemyheath;
            enemyheath = collision.gameObject.GetComponent<enemynoastar>();
            enemyheath.takedamage(damge.skill);
            bloodstatus.count++;
        
            bloodstatus.bloodstatus = true;
        }
        if (collision.CompareTag("bat"))
        {

            bloodbat bloodstatus;
            bloodstatus = collision.gameObject.GetComponent<bloodbat>();
            enemybatnoastar enemyheath;
            enemyheath = collision.gameObject.GetComponent<enemybatnoastar>();
            enemyheath.takedamage(damge.skill);
            bloodstatus.count++;
            
                bloodstatus.bloodstatus = true;
        }
        if (collision.CompareTag("worn"))
        {

            shottingblood bloodstatus;
            bloodstatus = collision.gameObject.GetComponent<shottingblood>();
            shottingnoastar enemyheath;
            enemyheath = collision.gameObject.GetComponent<shottingnoastar>();
            enemyheath.takedamage(damge.skill);
            bloodstatus.count++;

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
