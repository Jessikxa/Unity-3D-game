using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RayPoints : Shooting
{
    //public Transform FirePoint;
    //void Start()
    //{

    //}



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            shooting();
        }
    }
    public void shooting()
    {
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitInfo, 20f))
        {
            //Debug.Log("Hit Something");
            print(hitInfo.collider.gameObject.name);
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitInfo.distance, Color.red);

            ShootingTartget Enemy = hitInfo.transform.GetComponent<ShootingTartget>();
           
            if( _bulletNumber <= 0 )
            {
                if (Enemy != null)
                {
                    Enemy.TakeDamage(10);
                }
            }
            
            
            

        }
        else
        {
            Debug.Log("Hit nothing");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 20f, Color.green);
        }
    }
}




