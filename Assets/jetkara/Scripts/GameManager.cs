using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject objects;

	public TextMesh scoreLabel;
	public static int score;
	public int Score
	{
		set
		{
			score = value;

			scoreLabel.text = Score.ToString();
		}
		get
		{
			return score;
		}
	}

	void Start () 
	{
		score = 0;

		InvokeRepeating("CreateObjects", 1,2);
	}

	void CreateObjects()
	{
		Instantiate(objects, new Vector3(7.5f, Random.Range(-2f, 2.1f) , 0) , Quaternion.identity);
	}
}
