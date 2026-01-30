using UnityEngine;

public class CamFol : MonoBehaviour
{
    public GameObject FollowinfPlayer;
    public Vector3 offset;

    private void Update()
    {
        transform.position = FollowinfPlayer.transform.position + offset;
    }
}
