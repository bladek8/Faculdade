using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D cursorHand;
    public Texture2D cursorCloseHand;
    public float offset;
    public float speed;
    //x - min y - max
    public Vector2 minMaxXPosition;
    public Vector2 minMaxYPosition;
    private float screenWidth;
    private float screenHeight;
    private Vector3 cameraMove;
    public bool frezzed = false;
    // Use this for initialization
    void Start()
    {
        Cursor.SetCursor(cursorHand, new Vector2(1, 0), CursorMode.ForceSoftware);
        screenWidth = Screen.width;
        screenHeight = Screen.height;
        cameraMove.x = transform.position.x;
        cameraMove.y = transform.position.y;
        cameraMove.z = transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        if (!frezzed)
        {
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
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Cursor.SetCursor(cursorCloseHand, new Vector2(1, 0), CursorMode.ForceSoftware);

            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.name == "Pia")
                {
                    Debug.Log("---> Hit: ");
                }
            }
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
            Cursor.SetCursor(cursorHand, new Vector2(1, 0), CursorMode.ForceSoftware);
    }

    float MoveSpeed()
    {
        return speed * Time.deltaTime;
    }
}