using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 horSpeedVector = new Vector3(1, 0, 0);
    private Vector3 verSpeedVector = new Vector3(0, 0, 1);
    public float velocity = 5;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(horSpeedVector * velocity * Time.deltaTime * Input.GetAxis(InputAxes.HorizontalMove));
        transform.Translate(verSpeedVector * velocity * Time.deltaTime * Input.GetAxis(InputAxes.VerticalMove));
    }
}
