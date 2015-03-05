using UnityEngine;
using System.Collections;

//using Random = UnityEngine.Random;
public class MoveUI : MonoBehaviour {

	public float smooth;
	public float step;

	private Vector3 oldPosition;
	private bool moved = false;

	void Start()
	{
		oldPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update ()                                                 
	{
		if(moved)
		PositionChanging (step);
		else
			PositionChanging (0.0f);
	} 

	public void PositionChanging(float distance)
	{
		Vector3 newPosition = new Vector3 (oldPosition.x + distance, oldPosition.y,
		                                   oldPosition.z);
		
		//newPosition = position;
		transform.position = Vector3.Lerp (transform.position, newPosition, Time.deltaTime * smooth);
		Debug.Log (newPosition);
	}

	public void Toogle()
	{
		moved = !moved;
	}


}