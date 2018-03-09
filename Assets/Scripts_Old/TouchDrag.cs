using UnityEngine;
using System.Collections;

public class TouchDrag : MonoBehaviour
{

    // Update is called once per frame
    public float speed = 0.1F;



    void Update()
    {
          if (Input.touchCount == 1)
         {
            var touch = Input.touches[0];
            if (touch.position.y < Screen.width / 2 )
            {
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                    transform.Translate(0, touchDeltaPosition.y, 0);
                }
            else if (touch.position.y > Screen.width / 2 )
            {
                    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                    {
                        Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
                        transform.Translate(0, touchDeltaPosition.y, 0);
                    }
                }
          }
        }
    }
            
    
    /*{
        if (Input.touchCount > 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            transform.Translate( 0.0f, touchDeltaPosition.y * speed, 0.0f );
        }
        //if (Input.touchCount > 1)
        //{
        //   return;        // dashing the dreams of four player mode
        //}
        foreach (Touch touch in Input.touches)
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            Vector2 myPostion = gameObject.GetComponent<Rigidbody2D>().position;
            // if touch is within 2 units of my vertical axis
            if (Mathf.Abs(touchPos.x - myPostion.x) <= 1)
            {
                myPostion.y = Mathf.Lerp(myPostion.x, 0.0f, 0.0f);
                myPostion.y = Mathf.Clamp(myPostion.y, -50, 60);    // stay between -14 and 14 (screen height; YMMV)
                gameObject.GetComponent<Rigidbody2D>().position = myPostion;
            }
        }*/

}
