//Exercicio de RigidBody.

public float forca = 500f;
public Rigidbody2D bola;
public bool liberaPulo = false;
public int duplo = 2;

void Start()
{
	
}
void Update()
{
	if(liberaPulo == true) //Quando estiver permitido pular, ao apertar "Espaço", será dado força ao objeto!
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
		}
	}
}

void OnCollisionEnter2D(Collision2D outro) //Função para permitir pular caso o Objeto esteja colidindo no chão 
{
	if(outro.gameObject.CompareTag("chao"))
	{
		liberaPulo = true;
	}
}

void OnCollisionExit2D(Collision2D outro) //Função para proibir pular caso o Objeto não esteja colidindo no chão, ou seja,
{										  //se o objeto já está pulando.
	if(outro.gameObject.CompareTag("chao"))
	{
		liberaPulo = false;
	}
}