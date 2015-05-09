using UnityEngine;
using UnityEngine.UI;//Text
using System.Collections;


public class PlayerController : MonoBehaviour {

	public float speed;//allow to edit in inspector mode
	public GameObject player; // public so we can select object in inspector mode
	public Text ScoreText ; //public so we can attach Score text in inspector mode
	public Text WinText ;


	private int WIN_CODITION = 6;
	private int score;
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody>(); //ref rb to Rigidbody
		score = 0;//init score = 0
		UpdateScore ();
		WinText.text = "";


	}
	
	// Update is called once per frame
	void Update () {//non physic
		
		if (Input.GetKey ("escape"))
			Application.Quit ();

	}

	void FixedUpdate(){//physic
	
		float moveHorizontal = Input.GetAxis("Horizontal");//left right
		float moveVertical = Input.GetAxis("Vertical");//up down


		Vector3 v3 = new Vector3 (moveHorizontal,0.0f,moveVertical); //moving vector
		rb.AddForce (v3*speed);//add force to component



	}

	//called when it is trigged
	//at collider component, tick check box is trigger (for gold cube, not for player)
	//trigger don't feel  colision force
	void OnTriggerEnter(Collider other) {

		//compare tag to see if other is a gold cube
		if (other.gameObject.CompareTag ("Pick Up")) {
			other.gameObject.SetActive(false);//make gold cube disappear
			score = score+1;
		}
		UpdateScore ();

	}
	void UpdateScore()// 
	{
		ScoreText.text = "Score : " + score.ToString ();
		if (score >= WIN_CODITION) {
			WinText.text = "You Win !!! Meow ";
		
		}
	}
}
