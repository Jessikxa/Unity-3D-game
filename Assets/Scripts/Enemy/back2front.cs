using UnityEngine;

public class back2front : MonoBehaviour
{
    //Vector3 pointA = new Vector3(11, 1,-10);
    //Vector3 pointB = new Vector3(6, 1, -10);


    public Transform startMarker;
    public Transform endMarker;

    void Update()
    {
        transform.position = Vector3.Lerp(startMarker.position, endMarker.position, Mathf.PingPong(Time.time, 1));
    }
}
