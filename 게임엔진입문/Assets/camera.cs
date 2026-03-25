using UnityEngine;

public class PlayerFollowCam : MonoBehaviour
{
    public Transform player;

        float cameraOffset = -10.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = new Vector3(player.transform.position.x, player.transform.position.y, cameraOffset);
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime);
    }
}