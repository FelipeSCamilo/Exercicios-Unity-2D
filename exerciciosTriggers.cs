public bool liberaRot;
public GameObject ima;

void Start()
{
	liberaRot = false;
}

void Update()
{
	
	if(liberaRot == true) //Se a rotação estiver liberada, um objeto nomeado de "ima", irá rotacionar.
	{
		if(liberaRot == true)
		{
			ima.gameObject.transform.Rotate(new Vector3(0,0,5 * Time.deltaTime));
		}
	}
}

void OnTriggerEnter2D(Collider2D outro)  //Se um objeto com a tag "ave" entrar dentro do trigger, vai liberar a rotação
{
	if(outro.gameObject.CompareTag("ave"))
	{
		liberaRot = true;
	}
}

void OnTriggerExit2D(Collider2D outro)	//Se um objeto com a tag "ave" sair de dentro do trigger, vai parar a rotação
{
	if(outro.gameObject.CompareTag("ave"))
	{
		liberaRot = false;
	}
}