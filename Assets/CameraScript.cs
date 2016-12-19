using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	Vector2?[] oldTouchPositions = {
		null,
		null
	};
	Vector2 oldTouchVector;
	float oldTouchDistance;
	Vector2 firstPressPos;
	Vector2 secondPressPos;
	Vector2 currentSwipe;

	
	
	
	
	void Start(){
		
	} 
	void Update() {
		
		
		int nbTouches = Input.touchCount;

        if(nbTouches > 0)
        {
			
            Debug.Log("touches detected");

            for (int i = 0; i < nbTouches; i++)

            {
               Touch touch = Input.GetTouch(i);
                print("Touch index " + touch.fingerId + " detected at position " + touch.position);

            }
        }

	//INICIO
	/*
	     if(Input.touches.Length > 0)
     {
		 
		 
         Touch t = Input.GetTouch(0);
         if(t.phase == TouchPhase.Began)

        {
             //save began touch 2d point
         firstPressPos = new Vector2(t.position.x,t.position.y);
        }

        if(t.phase == TouchPhase.Ended)
        {

              //save ended touch 2d point

             secondPressPos = new Vector2(t.position.x,t.position.y);                       
              //create vector from the two points
             currentSwipe = new Vector3(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);

             //normalize the 2d vector

             currentSwipe.Normalize();

             //swipe upwards
             if(currentSwipe.y > 0  currentSwipe.x > -0.5f  currentSwipe.x < 0.5f)
             {
                 Debug.Log("up swipe");
             }

             //swipe down


             if(currentSwipe.y < 0  currentSwipe.x > -0.5f  currentSwipe.x < 0.5f)
                 Debug.Log("down swipe");


             //swipe left


             if(currentSwipe.x < 0  currentSwipe.y > -0.5f  currentSwipe.y < 0.5f)
				Debug.Log("left swipe");
             //swipe right

             if(currentSwipe.x > 0  currentSwipe.y > -0.5f  currentSwipe.y < 0.5f)
                 Debug.Log("right swipe");

         }
    }

	*/
	//FIN
	}
	
	
}

		
		
		/*
		if (Input.GetMouseButtonDown(0))
				Debug.Log("entro");
		if (Input.touchCount == 0) {
			
			oldTouchPositions[0] = null;
			oldTouchPositions[1] = null;
		}
		
		else if (Input.touchCount == 1) {
			
			if (oldTouchPositions[0] == null || oldTouchPositions[1] != null) {
				oldTouchPositions[0] = Input.GetTouch(0).position;
				oldTouchPositions[1] = null;
			}
			else {
				Vector2 newTouchPosition = Input.GetTouch(0).position;
				
				transform.position += transform.TransformDirection((Vector3)((oldTouchPositions[0] - newTouchPosition) * GetComponent<Camera>().orthographicSize / GetComponent<Camera>().pixelHeight * 2f));
				
				oldTouchPositions[0] = newTouchPosition;
			}
		}
		else {
			if (oldTouchPositions[1] == null) {
				oldTouchPositions[0] = Input.GetTouch(0).position;			
				oldTouchPositions[1] = Input.GetTouch(1).position;
				oldTouchVector = (Vector2)(oldTouchPositions[0] - oldTouchPositions[1]);
				oldTouchDistance = oldTouchVector.magnitude;
			}
			else {
				Vector2 screen = new Vector2(GetComponent<Camera>().pixelWidth, GetComponent<Camera>().pixelHeight);
				
				Vector2[] newTouchPositions = {
					Input.GetTouch(0).position,
					Input.GetTouch(1).position
				};
				Vector2 newTouchVector = newTouchPositions[0] - newTouchPositions[1];
				float newTouchDistance = newTouchVector.magnitude;

				transform.position += transform.TransformDirection((Vector3)((oldTouchPositions[0] + oldTouchPositions[1] - screen) * GetComponent<Camera>().orthographicSize / screen.y));
				transform.localRotation *= Quaternion.Euler(new Vector3(0, 0, Mathf.Asin(Mathf.Clamp((oldTouchVector.y * newTouchVector.x - oldTouchVector.x * newTouchVector.y) / oldTouchDistance / newTouchDistance, -1f, 1f)) / 0.0174532924f));
				GetComponent<Camera>().orthographicSize *= oldTouchDistance / newTouchDistance;
				transform.position -= transform.TransformDirection((newTouchPositions[0] + newTouchPositions[1] - screen) * GetComponent<Camera>().orthographicSize / screen.y);

				oldTouchPositions[0] = newTouchPositions[0];
				oldTouchPositions[1] = newTouchPositions[1];
				oldTouchVector = newTouchVector;
				oldTouchDistance = newTouchDistance;
			}
		}
	}*/
//} 




/*public class CameraScript : MonoBehaviour {
	
	private Vector2 worldStartPoint;

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	  // only work with one touch
    if (Input.touchCount == 1) {
        Touch currentTouch = Input.GetTouch(0);

        if (currentTouch.phase == TouchPhase.Began) {
            this.worldStartPoint = this.getWorldPoint(currentTouch.position);
        }

        if (currentTouch.phase == TouchPhase.Moved) {
            Vector2 worldDelta = this.getWorldPoint(currentTouch.position) - this.worldStartPoint;

            Camera.main.transform.Translate(
                -worldDelta.x,
                -worldDelta.y,
                0
            );
        }
    }
}

// convert screen point to world point
private Vector2 getWorldPoint (Vector2 screenPoint) {
    RaycastHit hit;
    Physics.Raycast(Camera.main.ScreenPointToRay(screenPoint), out hit);
    return hit.point;
}	


}*/
