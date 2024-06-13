using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawnManagerScript : MonoBehaviour
{
    //Global Variable Declarations

    [SerializeField]
    private GameObject _pipe;

    [SerializeField]
    private float _pipeSpawnRate = 4f;

    [SerializeField]
    private float _pipeOffset = 10f;

    [SerializeField]
    private GameObject _pipeContainer;

    private float _timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer < _pipeSpawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            _timer = 0;
        }

    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - _pipeOffset;
        float highestPoint = transform.position.y + _pipeOffset;

        Vector3 _randomPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);

        GameObject newPipe = Instantiate(_pipe, _randomPosition, Quaternion.identity);

        newPipe.transform.parent = _pipeContainer.transform;
    }


}


