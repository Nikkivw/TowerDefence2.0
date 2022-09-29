using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public static Transform[] wpoints;

    private void Awake()
    {
        wpoints = new Transform[transform.childCount];
        for (int i = 0; i < wpoints.Length; i++)
        {
            wpoints[i] = transform.GetChild(i);
        }
    }
}
