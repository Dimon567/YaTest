using UnityEngine;

public class PreFinishBehaviour : MonoBehaviour
{
    void FixedUpdate()
    {
        float x = Mathf.MoveTowards(transform.position.x, 0 , Time.deltaTime * 2f);
        float z = transform.position.z + 3f * Time.deltaTime;
        transform.position = new Vector3(x, 0, z);

        float rot = Mathf.MoveTowardsAngle(transform.eulerAngles.y, 0, Time.deltaTime * 60f);
        transform.eulerAngles = new Vector3(0, rot, 0);

    }
}
