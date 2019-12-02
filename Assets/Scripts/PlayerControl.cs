using UnityEngine;
public class PlayerControl : MonoBehaviour
{
    void Update()
    {
        Vector2 pos = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        transform.position += transform.forward * Time.deltaTime * 2 * pos.y;
        transform.position += transform.right * Time.deltaTime * 2 * pos.x;
    }
}
