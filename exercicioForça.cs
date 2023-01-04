public float forca = 2.5f;
public Rigidbody2D bola; 
/*Variável para mencionar qual Rigidbody irá ter um adicional de força. A menção será feita no editor do Unity, por isso
que a variável é publica.*/


void Start(){
	
}

void Update()
{
	if(Input.GetKeyDown(KeyCode.Space)) //Se a tecla espaço do teclado for apertada, adicione força ao Rididbody do GameObject bola
	{
		bola.AddForce( new Vector2(0,forca * Time.deltaTime), Forcemode2D.Impulse)
	}	
}	//"Forcemode2D.Impulse" é o tipo de força que se quer fazer, no caso de impulso (jogar para cima).