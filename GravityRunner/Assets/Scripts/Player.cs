using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    private float speed = 3.0f;
    private Button button;
    private Rigidbody2D playerBody;
    // Start is called before the first frame update
    void Awake()
    {
        button = GameObject.Find("JumpButton").GetComponent<Button>();
        button.onClick.AddListener(()=>Jump());
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = transform.position;
        playerPosition.x += Time.deltaTime * speed;
        transform.position = playerPosition;
    }

    void Jump() {
        playerBody.gravityScale *= -1;
        Vector3 scale = transform.localScale;
        scale.y *= -1;
        transform.localScale = scale;
    }
}
