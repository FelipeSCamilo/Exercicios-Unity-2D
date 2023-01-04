public float vel = 2.5f;
public int moedas = 0;

void Start()
{
	
}
void Update()
{
	
	if(Input.GetKey(KeyCode.RightArrow)) //movimento para direita
	{
		transform.translate( new Vector2(vel * Time.deltaTime,0));
	}
	if(Input.GetKey(KeyCode.LeftArrow)) //movimento para esquerda
	{
		transform.translate( new Vector2(-vel * Time.deltaTime,0));
	}

	print(moedas); //mostrar no console quantas moedas foram coletadas.
}

void OnTriggerEnder2D(Collider2D outro) //método de colisão do personagem com a moeda
{
	
	if(outro.gameobject.CompareTag("moeda")) //se o item colidido com o personagem for da TAG "moeda", o objeto será contabilizado em +1 e será destruido.
	{										   

		moeda++
		Destroy (outro.gameObject);
	}
}
