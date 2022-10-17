using System.Threading;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;

    private GameObject turret;
    //public GameObject TurretToBuild;
    public Vector3 posOffset;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.materials[1].color;

        buildManager = BuildManager.instance;
    }

    void OnMouseDown()
    {
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
   
        if (turret != null)
        {
            //Instantiate(turret);
            return;
        }
        GameObject turretTobuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretTobuild, transform.position + posOffset, transform.rotation);
        //GameObject turretToBuild = TurretToBuild;
        //turret = (GameObject)Instantiate(turretToBuild);
        //turret.transform.position = new Vector3(transform.position.x, 0.25f, transform.position.z);
    }

    void OnMouseEnter()
    {
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        rend.materials[1].color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.materials[1].color = startColor;
    }
}