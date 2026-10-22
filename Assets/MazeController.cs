using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
public class MazeController : MonoBehaviour
{

    public float maxTilt = 15f;
    public Transform ball;

    public float fallAmount = -1.0f;
    // Update is called once per frame
    void Update()
    {
        
        float xRotation = Input.GetAxis("Vertical") * maxTilt;
        float zRotation = Input.GetAxis("Horizontal") * maxTilt;
        transform.rotation = Quaternion.Euler(xRotation, 0f, zRotation);

        // now to reload the scene
        if (ball != null && ball.position.y < fallAmount){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }
}
