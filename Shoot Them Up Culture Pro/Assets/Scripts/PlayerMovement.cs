using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private Vector2 _screenBounds;
    private float _objectWidth, _objectHeight;

    // Start is called before the first frame update
    void Start()
    {
        _screenBounds =
            Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        _objectHeight = GetComponent<SpriteRenderer>().bounds.size.x;
        _objectWidth = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxisRaw("Horizontal") * Time.deltaTime * speed;
        float movementY = Input.GetAxisRaw("Vertical") * Time.deltaTime * speed;

        transform.Translate(new Vector3(movementX, movementY, 0));
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, _screenBounds.x * -1 + _objectWidth, _screenBounds.x - _objectWidth);
        pos.y = Mathf.Clamp(pos.y, _screenBounds.y * -1 + _objectHeight, _screenBounds.y - _objectHeight);
        transform.position = pos;
    }
}