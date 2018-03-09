using UnityEngine;
using System.Collections;


public class MoveRacket : MonoBehaviour
{
    public GameObject[] touchedObj = new GameObject[5];
    //private int speed;
    //private int speedIncrease;

    void Update()
    {
        Touch[] myTouches = Input.touches;
        //Get how much finger/tap in screen
        for (int i = 0; i < Input.touchCount; i++)
        {
            Vector3 mainPos = Camera.main.ScreenToWorldPoint(myTouches[i].position);
            Ray ray = Camera.main.ScreenPointToRay(myTouches[i].position);
            RaycastHit hit;
            mainPos.z = -4f;
            if (Physics.Raycast(ray, out hit, 20f))
            {
                //OnMouseDown()
                if (hit.collider != null && myTouches[i].phase == TouchPhase.Began)
                {
                    touchedObj[i] = hit.transform.gameObject;
                    print("Obj Touched!!");
                }
            }
            //OnMouseDrag
            int ID = myTouches[i].fingerId;
            if (touchedObj[ID] != null)
            {
                touchedObj[ID].transform.position = mainPos;
                print("Obj Dragged!!");
            }
            //OnMouseUp()
            if (myTouches[i].phase == TouchPhase.Ended && touchedObj[ID] != null)
            {
                touchedObj[ID].GetComponent<Rigidbody2D>().AddForce(Vector3.right * 50f);
                touchedObj[ID] = null;
                print("Obj Released!!");
            }
            if (Input.touchCount > 2)
            {
                return;        // dashing the dreams of four player mode
            }
            foreach (Touch touch in Input.touches)
            {
                Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
                Vector2 myPostion = gameObject.GetComponent<Rigidbody2D>().position;
                // if touch is within 2 units of my vertical axis
                if (Mathf.Abs(touchPos.x - myPostion.x) <= 2)
                {
                    myPostion.y = Mathf.Lerp(0.0f, touchPos.x, 0.0f);
                    myPostion.y = Mathf.Clamp(myPostion.y, 3, 12);    // stay between -14 and 14 (screen height; YMMV)
                    gameObject.GetComponent<Rigidbody2D>().position = myPostion;
                }
            }
        }
    }
}