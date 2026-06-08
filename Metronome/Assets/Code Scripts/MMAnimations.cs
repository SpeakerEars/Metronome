using UnityEngine;

public class MMAnimations : MonoBehaviour
{
    //GameObjects and such
    //Strings
    //Animators
    public Animator CameraAnim;
    public Animator MMCanvasAnim;
    //Booleans
	//CameraAnimBool
    public bool IsCameraCenter = true;
    public bool IsCameraMoveLeft = false;
    public bool IsCameraLeft = false;
    public bool IsCameraMoveCenter = false;
    public bool IsCameraMoveUp = false;
	//MMAnimBool
    public bool IsMMCenter = true;
    public bool IsMMMoveRight = false;
    public bool IsMMRight = false;
    public bool IsMMMoveCenter = false;
    public bool IsMMMoveDown = false;
    public bool IsMMDown = false;
    //Floats and Ints
    public float CameraAnimTimer = 0;
    public float MMAnimTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	//CameraAnimations
        if(IsCameraCenter)
	{
	    CameraAnim.Play("CameraCenterIdle");
	}
	if(IsCameraMoveLeft)
	{
	    CameraAnim.Play("CameraMoveRight");
	    CameraAnimTimer += Time.deltaTime;
	}
	if(CameraAnimTimer >= 0.5f && IsCameraMoveLeft)
	{
	    IsCameraLeft = true;
	    IsCameraMoveLeft = false;
	    CameraAnimTimer = 0;
	}
	if(IsCameraLeft)
	{
	    CameraAnim.Play("CameraLeftIdle");
	}
        if(IsCameraMoveCenter)
        {
	    CameraAnim.Play("CameraMoveCenter");
	    CameraAnimTimer += Time.deltaTime;
	}
	if(CameraAnimTimer >= 0.5f && IsCameraMoveCenter)
	{
	    IsCameraCenter = true;
	    IsCameraMoveCenter = false;
	    CameraAnimTimer = 0;
	}
	if(IsCameraMoveUp)
	{
	    CameraAnim.Play("CameraMoveUp");
	}

	//MMAnimations
	if(IsMMCenter)
	{
	    MMCanvasAnim.Play("MMCenter");
	}
	if(IsMMMoveRight)
	{
	    MMCanvasAnim.Play("MMMoveRight");
	    MMAnimTimer += Time.deltaTime;
	}
	if(MMAnimTimer >= 0.5 && IsMMMoveRight)
	{
	    IsMMRight = true;
	    IsMMMoveRight = false;
	    MMAnimTimer = 0;
	}
	if(IsMMRight)
	{
	    MMCanvasAnim.Play("MMRight");
	}
	if(IsMMMoveCenter)
	{
	    MMCanvasAnim.Play("MMMoveCenter");
	    MMAnimTimer += Time.deltaTime;
	}
	if(MMAnimTimer >= 0.5 && IsMMMoveCenter)
	{
	    IsMMCenter = true;
	    IsMMMoveCenter = false;
	    MMAnimTimer = 0;
	}
	if(IsMMMoveDown)
	{
	    MMCanvasAnim.Play("MMMoveDown");
	    MMAnimTimer += Time.deltaTime;
	}
	if(MMAnimTimer >= 0.5 && IsMMMoveDown)
	{
	    IsMMDown = true;
	    IsMMMoveDown = false;
	    MMAnimTimer = 0;
	}
	if(IsMMDown)
	{
	    MMCanvasAnim.Play("MMDown");
	}
    }
    public void Options()
    {
	IsCameraCenter = false;
	IsCameraMoveLeft = true;
	IsMMCenter = false;
	IsMMMoveRight = true;
    }
    public void LeaveOptions()
    {
        IsCameraLeft = false;
        IsCameraMoveCenter = true;
	IsMMRight = false;
	IsMMMoveCenter = true;
    }
    public void PlayGame()
    {
        IsCameraCenter = false;
	IsCameraMoveUp = true;
	IsMMCenter = false;
	IsMMMoveDown = true;
    }
}
