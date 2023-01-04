//Implementando Inputs de teclado.

private float vel = 2.5f;

void Start ()
{
	
}

void Update ()
{
	if(Input.GetKey(Keycode.RightArrow)) 
		transform.Translate (new Vector3 (vel * Time.deltaTime,0,0)); 
	}

	if(Input.GetKey(Keycode.LeftArrow))
	{
		transform.Translate (new Vector3 (-vel * Time.deltaTime,0,0));
	}

	if(Input.GetKey(Keycode.UpArrow))  
	{
		transform.Translate (new Vector3 (0,vel * Time.deltaTime,0)); 
	}

	if(Input.GetKey(Keycode.DownArrow)) 
	{
		transform.Translate (new Vector3 (0,-vel * Time.deltaTime,0));
    }

/* 
Implementando Inputs de teclado via Axis

void Update()
{
float H = Input.GetAxis("Horizontal"); //No String dentro das aspas, lembre de colocar o nome EXATO do Axis que você quer para evitar erros.
float V = Input.GetAxis("Vertical");

transform.Translate (new Vector3 (H * Time.deltaTime, V * Time.deltaTime,0));

} */

/*Implementando Inputs de Mouse via Axis

void Update()
{

float H = Input.GetAxis("Mouse X");
float V = Input.GetAxis("Mouse Y");

transform.Translate (new Vector3 (H * Time.deltaTime, V * Time.deltaTime,0));

}
*/

/*
Implementando Inputs de Joystick via Axis através do link: //forum.unity.com/threads/ps3-button-map.89288/

void Update()
{
float H = Input.GetAxis("triangulo");

transform.Translate (new Vector3 (H * Time.deltaTime, 0,0));

}
*/