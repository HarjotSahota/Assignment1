using UnityEngine;

public class BallController : MonoBehaviour
{

    // to use rigidbody componenets
    [SerializeField] private Rigidbody sphereRigidbody;
    // to change speed
    [SerializeField] private float ballSpeed = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // prints out console message when Start method is called
        Debug.Log("Calling the Start method");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector2 inputVector = Vector2.zero;          // initialize input vector

        if (Input.GetKey(KeyCode.W)){
            inputVector += Vector2.up;
            Debug.Log(Vector2.up);
        }
        if (Input.GetKey(KeyCode.S)){
            inputVector += Vector2.down;
            Debug.Log(Vector2.down);
        }
        if (Input.GetKey(KeyCode.D)){
            inputVector += Vector2.right;
            Debug.Log(Vector2.right);
        }
        if (Input.GetKey(KeyCode.A)){
            inputVector += Vector2.left;
            Debug.Log(Vector2.left);
        }

        // allows input to control movement on the desired plane
        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputXZPlane);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
        



        
    }
}
