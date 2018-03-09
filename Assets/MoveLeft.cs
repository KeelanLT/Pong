using UnityEngine;
using System.Collections;

public class MoveLeft : MonoBehaviour
{

    // Update is called once per frame
    public float speed = 0.1F;



    void Update()
    {
       
        if (Input.touchCount > 0)
        {
            var touch = Input.touches[0];
            if (touch.position.x < Screen.height / 2)
            {
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    Vector2 racketPos1 = Input.GetTouch(0).deltaPosition;
                    transform.Translate(0, racketPos1.y * speed, 0);
                }
            }
        }
    }
}