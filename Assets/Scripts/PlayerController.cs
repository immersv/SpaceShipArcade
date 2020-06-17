using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float shipSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (Vector3.forward*shipSpeed*Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right*shipSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left*shipSpeed * Time.deltaTime);
        }
    }
}
