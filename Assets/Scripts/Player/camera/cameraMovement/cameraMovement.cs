using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public float mouseSensitivity = 200f;

    public Transform playerBody;

    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    
    }



    //public float Sensitivity
    //{
    //    get { return sensitivity; }
    //    set { sensitivity = value; }
    //}
    //[Range(0.1f, 9f)][SerializeField] float sensitivity = 2f;
    //[Tooltip("Limits vertical camera rotation. Prevents the flipping that happens when rotation goes above 90.")]
    //[Range(0f, 90f)][SerializeField] float yRotationLimit = 88f;

    //Vector2 rotation = Vector2.zero;
    //const string xAxis = "Mouse X"; 
    //const string yAxis = "Mouse Y";

    //void Update()
    //{
    //    rotation.x += Input.GetAxis(xAxis) * sensitivity;
    //    rotation.y += Input.GetAxis(yAxis) * sensitivity;
    //    rotation.y = Mathf.Clamp(rotation.y, -yRotationLimit, yRotationLimit);
    //    var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
    //    var yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left);

    //    transform.localRotation = xQuat * yQuat; 
    //}
}
