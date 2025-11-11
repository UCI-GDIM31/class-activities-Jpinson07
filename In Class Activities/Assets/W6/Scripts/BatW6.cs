using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour

{
    [SerializeField] private float _speed;
    public void startchasing(Transform playerTransform)
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, _speed * Time.deltaTime);
    }

    public void endchasing(Transform playerTransform)
    {
        transform.position = new Vector3(0, 0, 0);
    }


}
