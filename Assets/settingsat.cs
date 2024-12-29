using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settingsat : MonoBehaviour
{
    public GameObject pannel;
    public float lineOfSite = 2f;
   
    public Transform player;
    public Rigidbody rb;
    public Animator anim;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        anim = GetComponent<Animator>();
    }
    private void Update()
    {

        float distancefromplayer = Vector2.Distance(player.position, transform.position);
        if (distancefromplayer < lineOfSite)
        {
            if (Input.GetKeyDown(KeyCode.E))
                pannel.SetActive(true);
            else if (Input.GetKeyDown(KeyCode.Escape))
                pannel.SetActive(false);

        }
        

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }
}
