using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{ 
    public Color hoverColor;

    public GameObject turret;
    public GameObject TurretToBuild;
    
    private Renderer rend;
    private Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.materials[1].color;
    }

    void OnMouseDown()
    {
        if (turret = null)
        {
            Instantiate(turret);
        }
        GameObject turretToBuild = TurretToBuild;
        turret = (GameObject)Instantiate(turretToBuild);
        turret.transform.position = new Vector3(transform.position.x, 0.25f, transform.position.z);
    }
    
    void OnMouseEnter()
    {
        rend.materials[1].color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.materials[1].color = startColor;
    }
}