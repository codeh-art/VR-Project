using UnityEngine;
public class PlayerControl : MonoBehaviour
{
    Vector3 pos2;
    void Update()
    {
        Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        if (Input.GetKey("z"))
        {
            pos2 = Vector3.forward;
        }
        if (Input.GetKey("s"))
        {
            pos2 = Vector3.back;
        }
        if (Input.GetKey("q"))
        {
            pos2 = Vector3.left;
        }
        if (Input.GetKey("d"))
        {
            pos2 = Vector3.right;
        }
        if(Input.GetKey("a"))
        {
            pos2 = Vector3.down;
        }
        if (Input.GetKey("e"))
        {
            pos2 = Vector3.up;
        }
        transform.position += Time.deltaTime * 2 * pos2;
        pos2 = Vector3.zero;
    }
}
