using UnityEngine;

public class PlaysoundForMe : MonoBehaviour
{
    public AudioSource mainAudio;
    public AudioClip testClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
	if(collision.gameObject.CompareTag("Basic Trigger"))
	{
	    mainAudio.PlayOneShot(testClip);
	    Debug.Log("I SWEAR IT WORKS");
	}
    }
}
