using UnityEngine;


public class Fire : MonoBehaviour
{
	float _time;

	void OnEnable () 
	{
		_time = Time.time + 0.3f;
	}
	
	void FixedUpdate () 
	{
		if (_time < Time.time)
		 gameObject.SetActive(false);
	}
}
