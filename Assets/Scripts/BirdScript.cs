using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    //Global Variable Declarations

    [SerializeField]
    private Rigidbody2D _birdRigidbody;

    [SerializeField]
    private float _flapStrength = 5;

    private UIManagerScript _uiManagerhandler;

    private bool _isBirdAlive = true;

    [SerializeField]
    private GameObject _wingFlap;
    private SpriteRenderer _wingFlapSpriteRenderer;

    [SerializeField]
    private Sprite[] _wingSprites;

    // Start is called before the first frame update
    void Start()
    {
        _birdRigidbody = GetComponent<Rigidbody2D>();
        _uiManagerhandler = GameObject.Find("Canvas").GetComponent<UIManagerScript>();

        _wingFlapSpriteRenderer = GameObject.Find("WingFlap").GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _isBirdAlive)
        {
            _birdRigidbody.velocity = Vector2.up * _flapStrength;
            _wingFlapSpriteRenderer.sprite = _wingSprites[1];
           
        }

        if(Input.GetKeyUp(KeyCode.Space) && _isBirdAlive)
        {
            _wingFlapSpriteRenderer.sprite = _wingSprites[0];
        }

        float upperBound = 13f;
        float lowerBound = -13f;
        if (transform.position.y > upperBound || transform.position.y < lowerBound)
        {
            _isBirdAlive = false;
            _uiManagerhandler.SetGameOver();
        }
      
    }

    private void OnCollisionEnter2D(Collision2D collisionObject)
    {
        Debug.Log("Collision::Pipe");
            _isBirdAlive = false;
            _uiManagerhandler.SetGameOver();

    }

    public bool CheckIsBirdAlive()
    {
        return _isBirdAlive;
    }
}
