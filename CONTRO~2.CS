using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsNew1 : MonoBehaviour {

	public Transform[] positions;
	public Transform[] outerNodes;

	public Sprite[] playerSprites;
	private SpriteRenderer spriteRenderer;

	public Transform player;
    public Rigidbody2D playerRigidbody;

	public int Speed = 3;
    private int moveNum = 0;

	public AudioClip[] audioClips;
	public AudioSource audioSource;


    public bool moving;

	// Use this for initialization
	void Start () {

		player = this.gameObject.transform;

		spriteRenderer = player.GetComponent<SpriteRenderer>();

        playerRigidbody = GetComponent<Rigidbody2D>();

		positions = new Transform[25];
		outerNodes = new Transform[8];

		positions [0] = GameObject.Find("Node 1").transform;
		positions [1] = GameObject.Find("Node 6").transform;
        positions [2] = GameObject.Find("Node 2").transform;
        positions [3] = GameObject.Find("Node 14").transform;
        positions [4] = GameObject.Find("Node 11").transform;
        positions [5] = GameObject.Find("Node 17").transform;
        positions[6] = GameObject.Find("Node 7").transform;
        positions[7] = GameObject.Find("Node 12").transform;
        positions[8] = GameObject.Find("Node 15").transform;
        positions[9] = GameObject.Find("Node 8").transform;
        positions[10] = GameObject.Find("Node 5").transform;
        positions[11] = GameObject.Find("Node 13").transform;
        positions[12] = GameObject.Find("Node 16").transform;
        positions[13] = GameObject.Find("Node 9").transform;
        positions[14] = GameObject.Find("Node 10").transform;
        positions[15] = GameObject.Find("Node 3").transform;
        positions[16] = GameObject.Find("Node 4").transform;
		//Outer Nodes
		positions [17] = GameObject.Find ("OuterNode1").transform;
		positions [18] = GameObject.Find ("OuterNode2").transform;
		positions [19] = GameObject.Find ("OuterNode3").transform;
		positions [20] = GameObject.Find ("OuterNode4").transform;
		positions [21] = GameObject.Find ("OuterNode5").transform;
		positions [22] = GameObject.Find ("OuterNode6").transform;
		positions [23] = GameObject.Find ("OuterNode7").transform;
		positions [24] = GameObject.Find ("OuterNode8").transform;


        player.position = positions[4].position;
	
	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.tag == "powerUp") {
			playPowerUp ();
		}
	}


	// Update is called once per frame
	void Update () {

		checkSpeed ();


        #region Level One Controls

        if (moving == true)
        {
            MovePlayer(player, positions[moveNum]);
        }

		if(moving == false){
			if (Input.GetKey(KeyCode.UpArrow))
			{
				spriteRenderer.sprite = playerSprites[0];
			}
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				spriteRenderer.sprite = playerSprites[2];
			}
			else if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				spriteRenderer.sprite = playerSprites[3];
			}
			else if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				spriteRenderer.sprite = playerSprites[1];
			}
		}

        if (player.position == positions[0].position)
        {
			if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moving = true;
                moveNum = 1;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 2;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 4;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 3;
                moving = true;
				playAudio();

			}else{
				moving = false;
			}
        }else if(player.position == positions[1].position)
        {
			if(Input.GetKeyDown(KeyCode.UpArrow)){
				moveNum = 18;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 5;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 6;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 0; 
                moving = true;
				playAudio();

			}else{
                moving = false;
			}
        }
        else if (player.position == positions[2].position)
        {
			if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveNum = 5;
                moving = true;
				playAudio();

            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 0;
                moving = true;
				playAudio();
			}else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 15;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 8;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[3].position)
        {
			if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveNum = 0;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 7;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 8;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 22;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[4].position)
        {
			if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveNum = 6;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 14;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 0;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 7;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[5].position)
        {
			if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveNum = 17;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 1;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 10;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 2;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[6].position)
        {
			if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveNum = 19;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 9;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 1;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 4;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[7].position)
        {
			if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveNum = 4;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 11;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 3;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 21;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[8].position)
        {
			if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveNum = 2;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 3;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 12;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 23;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[9].position)
        {
			if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 6;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 13;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[10].position)
        {
			if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                moveNum = 5;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                moveNum = 16;
                moving = true;
				playAudio();
			}else{
				moving = false;
			}
        }
        else if (player.position == positions[11].position)
        {
			if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                moveNum = 7;
                moving = true;
				playAudio();
            }
			else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                moveNum = 14;
				moving = true;
				playAudio();
			}else{
				moving = false;
			}
		}
		else if (player.position == positions[12].position)
		{
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				moveNum = 15;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				moveNum = 8;
				moving = true;
				playAudio();
			}else{
				moving = false;
			}
		}else if(player.position == positions[13].position){
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				moveNum = 9;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				moveNum = 14;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				moveNum = 20;
				moving = true;
				playAudio();
			}else{
				moving = false;
			}
		}else if(player.position == positions[14].position){
			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				moveNum = 11;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				moveNum = 4;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				moveNum = 13;
				moving = true;
				playAudio();
			}else{
				moving = false;
			}
		}else if(player.position == positions[15].position){
			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				moveNum = 12;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				moveNum = 16;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				moveNum = 2;
				moving = true;
				playAudio();
			}else{
				moving = false;
			}
		}else if(player.position == positions[16].position){
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				moveNum = 10;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				moveNum = 24;
				moving = true;
				playAudio();
			}
			else if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				moveNum = 15;
				moving = true;
				playAudio();
			}else{
				moving = false;
			}
		}else if(player.position == positions[17].position){
			player.transform.position = positions[23].position;
			moveNum = 8;
			moving = true;
		}else if(player.position == positions[18].position){
			player.transform.position = positions[22].position;
			moveNum = 3;
			moving = true;
		}else if(player.position == positions[19].position){
			player.transform.position = positions[21].position;
			moveNum = 7;
			moving = true;
		}else if(player.position == positions[20].position){
			player.transform.position = positions[24].position;
			moveNum = 16;
			moving = true;
		}else if(player.position == positions[21].position){
			player.position = positions[19].position;
			moveNum = 6;
			moving = true;
		}else if(player.position == positions[22].position){
			player.position = positions[18].position;
			moveNum = 1;
			moving = true;
		}else if(player.position == positions[23].position){
			player.position = positions[17].position;
			moveNum = 5;
			moving = true;
		}else if(player.position == positions[24].position){
			player.position = positions[20].position;
			moveNum = 13;
			moving = true;
		}
		
        #endregion

    }

	void checkSpeed () {

		if (Speed == 1 || Speed == 4) {
			StartCoroutine(speedTime());				
		}
	}


	IEnumerator speedTime (){

		yield return new WaitForSeconds (3f);
		Speed = 3;

	}

    void MovePlayer(Transform player, Transform endPosition)
    {
        float step = Speed * Time.deltaTime;



        player.position = Vector3.MoveTowards(player.position, endPosition.position, step);

    }

	void playAudio(){

		audioSource.clip = audioClips[0];
		audioSource.Play ();
	}

	void playAudioAtJunction(){
		audioSource.clip = audioClips [1];
		audioSource.Play ();
	}

	void playPowerUp(){
		audioSource.clip = audioClips[1];
		audioSource.Play ();
	}


}
