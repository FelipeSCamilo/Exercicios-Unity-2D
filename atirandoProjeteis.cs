public GameObject balas;
public GameObject cano;
public float vel= 2.5f; //Usando uma variável de velocidade pois está se tratando de movimentação.

void Start()
{
	
}
void Update()
{
	if(Input.GetKeyDown(KeyCode.Space)) //Criando projéteis (prefabs) na posição do gameobject cano ao apertar espaço.
	{
		Instantiate(balas, new Vector3(cano.transform.position.x, cano.transform.position.y, cano.transform.position.z), cano.transform.rotation);
	}

    transform.Translate (new Vector2(vel * Time.deltaTime,0)); //Para atirar para frente, é necessário usar apenas o eixo X.
}
