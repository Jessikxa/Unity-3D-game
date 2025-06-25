using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform FirePoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Shooting();
        }
        
    }

    private void Shooting()
    {
        RaycastHit hit;
        if(Physics.Raycast(FirePoint.transform.position, FirePoint.transform.forward, out hit))
        {
            Debug.Log(hit.transform.name);

            ShootThem enemy = hit.transform.GetComponent<ShootThem>();
            if(enemy != null)
            {
                enemy.TakeDamage(10);
            }
        }
    }
}
