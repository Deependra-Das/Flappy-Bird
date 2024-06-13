using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    //Global Variable Declarations

    [SerializeField]
    private float _pipeMoveSpeed = 20f;

    private float _pipeDeadZone = -40f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * _pipeMoveSpeed * Time.deltaTime);

        if(transform.position.x < _pipeDeadZone)
        {
            Destroy(this.gameObject);
        }
    }
}
