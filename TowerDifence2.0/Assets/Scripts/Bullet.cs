using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    private Transform target;

    public float speed;

    public int damage;

    public void Seek(Transform _Target)
    {
        target = _Target;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        Vector3 dir = target.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame)
        {
            HitTarget();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }
    void HitTarget()// Enemy health
    {
        target.GetComponent<Enemy>().health -= damage;
        target.GetComponent<Enemy>().healthBar.fillAmount = target.GetComponent<Enemy>().health / target.GetComponent<Enemy>().startHealth;
        if (target.GetComponent<Enemy>().health <= 0)
        {
            Destroy(target.gameObject);
        }
        Destroy(gameObject);
    }
}