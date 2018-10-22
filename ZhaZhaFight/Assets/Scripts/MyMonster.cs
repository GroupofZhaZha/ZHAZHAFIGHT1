using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyMonster : MonoBehaviour {

    public float healthpoint = 100f;
    private float MAXHEALTH = 100f;
    public float range = 10f;
    public float speed = 10f;
    private Transform target;
    public string enemyTag = "Enemy";
    private Animator anim;
    private float attackSpeed = 1f;
    private float attackCooldown = 2.1f;
    public Image healthbar;

	// Use this for initialization
	void Start () {
        anim = transform.GetComponent<Animator>();  
        healthbar = transform.GetChild(0).GetComponent<Image>();
        healthbar.type = Image.Type.Filled;
        return;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthBar();

        if (GameObject.FindGameObjectsWithTag(enemyTag).Length <= 0)
        {
            anim.SetBool("Move", false);
            anim.SetBool("Attack", false);
            return;
        }

        if (target == null)
        {
            UpdateNearestEnemy();
            return;
        }
        

        float distance = Vector3.Distance(transform.position, target.transform.position);

        if (distance <= range)
        {
           
            anim.SetBool("Attack", true);
            anim.SetBool("Move", false);
            if (attackCooldown >= 0)
            {
                attackCooldown -= Time.deltaTime;
                return;
            }
            target.GetComponent<AIMonster>().damageReceive(10);
            attackCooldown = 2.1f;

        }
        else 
        {
            anim.SetBool("Attack", false);
            anim.SetBool("Move", true);
            Vector3 direc = target.position - transform.position;
            transform.Translate(direc.normalized * speed * Time.deltaTime, Space.World);
        }
        
    }

    void UpdateHealthBar()
    {
        healthbar.fillAmount = healthpoint / MAXHEALTH;
        if (healthpoint <= 0f)
        {
            Destroy(gameObject);
        }
    }

    void UpdateNearestEnemy()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                nearestEnemy = enemy;
            }
        }
        target = nearestEnemy.transform;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;   
        Gizmos.DrawWireSphere(transform.position, range);
    }

    public void damageReceive(float damage)
    {
        healthpoint -= damage;
    }

}
