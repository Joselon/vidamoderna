using UnityEngine;
using System.Collections;

public class HitController : MonoBehaviour {

  public BallScript ball;

  private float forceY = -1.0f;
  private float forceX = 2.0f;

  void OnMouseDown() {
    Vector3 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition|| Input.GetTouch(0).position.) + new Vector3(forceX, forceY, 0);
    ball.setForce(vec);
  }

  void OnMouseDrag() {
    Vector3 vec = Camera.main.ScreenToWorldPoint(Input.mousePosition|| Input.GetTouch(0).position) - ball.transform.position - new Vector3(forceX, forceY, 0);
    ball.setForce(vec);
  }

  void OnMouseUp() {
    if (!ball.isFired) ball.shot();
  }
}
