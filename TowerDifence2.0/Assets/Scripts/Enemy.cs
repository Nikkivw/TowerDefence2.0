
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    void Start()
    {
        target = Waypoints.wpoints[0];
    }

   void Update()
   {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(transform.position, target.position) <= 0.4f)
        {
            GetNextWaypoint();
        }
   }

    void GetNextWaypoint()
    {
        if(wavepointIndex >= Waypoints.wpoints.Length - 1)
        {
            Destroy(gameObject);
        }
        wavepointIndex++;
        target = Waypoints.wpoints[wavepointIndex];
    }
}
