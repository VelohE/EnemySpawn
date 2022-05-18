using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody player;
    public float speed = 5.0f;
    private GameObject focalPoint;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");}

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        player.AddForce(forwardInput * speed * Time.deltaTime * focalPoint.transform.forward);}
}
