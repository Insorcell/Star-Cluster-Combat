using UnityEngine;

public class Ship : MonoBehaviour {
    public Rigidbody2D rb;
    public int speed = 100;
    bool left = false;
    bool right = false;

    private void Update ()
    {
        if (left)
        {
            rb.AddForce(new Vector2(-(speed * Time.deltaTime), 0));
        }
        if (right)
        {
            rb.AddForce(new Vector2(speed * Time.deltaTime, 0));
        }
    }

    public void MoveShipLeft ()
    {
        left = !left;
    }

    public void MoveShipRight ()
    {
        right = !right;
    }
}
