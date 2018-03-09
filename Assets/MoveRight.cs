using UnityEngine;
using System.Collections;

public class MoveRight : MonoBehaviour
{

    // Update is called once per frame
    public float speed = 0.1F;
    public float velocity = 10;



    void Update()
    {
        
        if (Input.touchCount > 0)
        {
            var touch = Input.touches[0];
            if (touch.position.x > Screen.height / 2)
            {
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    Vector2 racketPos = Input.GetTouch(0).deltaPosition;
                    transform.Translate(0, racketPos.y * speed, 0);
                }
            }
        }
    }
}