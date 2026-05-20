using UnityEngine;

public class NoteTileBehaviour : MonoBehaviour
{
    float defaultSpeed; //Use this speed measure to always make as fast as Time.deltaTime. That way, it will move 1 tile each second.
    public float BPM;
    public float moveSpeed; //This is how fast you want them to actually move by the end of it. moveSpeed will just be whatever comes out of the equation
    public float difficultyMultiplier; //multiply the speed by however you want to make it harder or easier to read and be prepared for
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        defaultSpeed = Time.deltaTime;
	moveSpeed = BPM * 16 / 60 / difficultyMultiplier;
	transform.Translate(Vector3.down * moveSpeed * Time.deltaTime, Space.World);
    }
}
