using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float min_Y, max_Y;

    [SerializeField]
    private GameObject player_Bullet;
    public float attack_Timer = 0.35f;
    private float current_Attack_Timer;
    private bool can_Attack;
    [SerializeField]
    private Transform attackPoint;
    // Start is called before the first frame update
    void Start()
    {
        current_Attack_Timer = attack_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
        Attack();
    }

    void movePlayer()
    {
        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;
            if (temp.y > max_Y) temp.y = max_Y;

            transform.position = temp;
        }else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;
            if (temp.y < min_Y) temp.y = min_Y;
            transform.position = temp;
        }
    }
    void Attack()
    {
        attack_Timer += Time.deltaTime;
        if(attack_Timer > current_Attack_Timer)
        {
            can_Attack = true;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (can_Attack)
            {
                can_Attack = false;
                attack_Timer = 0f;
                Instantiate(player_Bullet, attackPoint.position, Quaternion.Euler(0, 0, 90));
            }    }

    }
}
