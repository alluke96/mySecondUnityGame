using UnityEngine;

public class LookTowardMouse : MonoBehaviour {
 
     // Update is called once per frame
     void Update () 
     {
         //Lembrar de ver a razão de alguns angulos ficarem errados ao rotacionar o mouse
         
         //Get the Screen positions of the object
         Vector2 positionOnScreen = Camera.main.WorldToViewportPoint (transform.position);
         
         //Get the Screen position of the mouse
         Vector2 mouseOnScreen = Camera.main.ScreenToViewportPoint(Input.mousePosition);
         
         //Get the angle between the points
         float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen);
 
         //Ta Daaa
         transform.rotation =  Quaternion.Euler (new Vector3((this.transform.position.x - 90),-angle, (this.transform.position.z + 90)));
     }
 
     float AngleBetweenTwoPoints(Vector3 a, Vector3 b) {
         return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
     }
 
 }