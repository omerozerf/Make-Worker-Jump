using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Transform[] transforms;
    

    private void Update()
    {
        XMovement();
        AreaLimit();
    }

    private void XMovement()
    {
        foreach (var subTransform in transforms)
        {
            var deltaPosition = Vector3.left * speed * Time.deltaTime;
            subTransform.position = subTransform.position + deltaPosition;
        }
    }

    private void AreaLimit()
    {
        var transformLenght = Mathf.Abs(transforms[0].position.x - transforms[1].position.x);
        
        foreach (var subTransform in transforms)
        {
            if (subTransform.position.x < -68f)
            {
                subTransform.position = subTransform.position + Vector3.right * (transformLenght * 2f);
            }
        }
    }
}
