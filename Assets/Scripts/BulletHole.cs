using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class BulletHole : MonoBehaviour
{
    public Transform _gunBarrel;
    public GameObject _bulletHolePrefab;

    void Start()
    {
    }

    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            HoleBullet();
        } 

       
    }

    private void HoleBullet()
    {

        Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(rayOrigin, out hitInfo))
        {

            if (hitInfo.collider.tag == "Wall")
            {
                Instantiate(_bulletHolePrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));

                Vector3 direction = hitInfo.point - _gunBarrel.position;
                _gunBarrel.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
                //LookRotation
            }
        }
    }


   



















    //public GameObject _bulletHole;
    //public LayerMask _canBeShot;
    ////Camera _camera;

    //void Start()
    //{
    //    //_camera = Camera.main;
    //}

    //void Update()
    //{
    //    Transform t_spawn = transform.Find("Player/Capsule/Main Camera");

    //    if (Input.GetButtonDown("Fire1"))
    //    {
    //        RaycastHit hit =new RaycastHit();
    //        if(Physics.Raycast(t_spawn.position,t_spawn.forward,out hit, 1000f, _canBeShot))
    //        {
    //            GameObject bH = Instantiate(_bulletHole, hit.point + hit.normal * 0.001f, Quaternion.identity) as GameObject;
    //            _bulletHole.transform.LookAt(hit.point + hit.normal);

    //            Destroy(_bulletHole, 5f);
    //        }
    //    } 
    //}
}
