using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New : MonoBehaviour
{
    public Texture2D cursorTexture;
    public float offset;
    public float speed;
    //x - min y - max
    public Vector2 minMaxXPosition;
    public Vector2 minMaxYPosition;
    private float screenWidth;
    private float screenHeight;
    private Vector3 cameraMove;
    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(cursorTexture, new Vector2(1, 0), CursorMode.ForceSoftware);
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        cameraMove.x = transform.position.x;
        cameraMove.y = transform.position.y;
        cameraMove.z = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        //Move camera
        if ((Input.mousePosition.x > screenWidth - offset) && transform.position.x < minMaxXPosition.y)
        {
            cameraMove.x += MoveSpeed();
        }
        if ((Input.mousePosition.x < offset) && transform.position.x > minMaxXPosition.x)
        {
            cameraMove.x -= MoveSpeed();
        }
        if ((Input.mousePosition.y > screenHeight - offset) && transform.position.y < minMaxYPosition.y)
        {
            cameraMove.y += MoveSpeed();
        }
        if ((Input.mousePosition.y < offset) && transform.position.y > minMaxYPosition.x)
        {
            cameraMove.y -= MoveSpeed();
        }
        transform.position = cameraMove;
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Debug.Log(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }

    float MoveSpeed()
    {
        return speed * Time.deltaTime;
    }
}

//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Mouse : MonoBehaviour {

//    void Start () {
//        Cursor.SetCursor(cursorTexture, new Vector2(1, 0), CursorMode.ForceSoftware);
//    }

//	void FixedUpdate ()
//    {
//        if(Input.GetKeyDown(KeyCode.Mouse0))
//            Debug.Log(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
//    }
//}
