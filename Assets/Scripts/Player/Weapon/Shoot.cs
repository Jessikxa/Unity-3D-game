using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform FirePoint;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
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
            //BackAndForthMovement target = hit.transform.GetComponent<BackAndForthMovement>();
            if(enemy != null)
            {
                enemy.TakeDamage(10);
            }

            //if(target != null)
            //{
            //    target.hasShot = true;
            //}
        }
    }
}
