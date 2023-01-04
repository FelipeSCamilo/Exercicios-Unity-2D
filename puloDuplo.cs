//Exercicio de Rigidbodys

public float forca = 500f;
public Rigidbody2D bola;
public int duplo = 2;

void Start()
{
	
}
void Update()
{
	if(duplo > 0) //Quando estiver permitido pular duas vezes, ao apertar "Espaço", será dado força ao objeto!
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);

			duplo--; //Esse decremento diminui 1 pulo a cada vez que se aperta "Espaço". Quando chega a 0, cai no chão para restaurar os 2 pulos novamente.
		}
	}
}

void OnCollisionEnter2D(Collision2D outro) //Código para permitir pular 2 vezes caso o Objeto esteja colidindo no chão.
{
	if(outro.gameObject.CompareTag("chao"))
	{
		duplo = 2;
	}
}
