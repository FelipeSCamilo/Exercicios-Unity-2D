/*Criando um Gerenciador de Aúdio para os audios de uma cena. */

public class Gerenciador : Monobehaviour {
	
	public AudioSource sons;
	public Static Gerenciador isnt = null; // Essa variável que permite esse Script ser chamado por outros Scripts! Inst = Instancia

	void Awake() //Esse método é melhor para trabalhar com Gerenciadores pois ele entra em ação mesmo com o Script desabilitado, diferente do
				 //método Start.
	{
		if(inst == null) //Se essa instancia for nula (como foi declarado na variável), a instancia vai ser igual ao GameObject onde esse
					     //Script está sendo implementado.
		{
			inst = this;
		}

		else if(inst != this) //Se a instancia for diferente do GameObject onde esse Script está sendo implementado, destrua o objeto
							  //diferente.
		{
			Destroy (gameObject);
		}
	}
	
	public void PlayAudio(AudioClip clipAudio) //AudioClip é o audio a ser colocado
	{
		sons.clip =  clipAudio; //Aqui tá dizendo que o audio colocado será igual ao audio que foi colocado na variável som.
		sons.Play (); //aqui vai tocar o audio que foi passada para a variável som.
	}

}

/*
Implementando sons em scripts já feitos através do gerenciador de audios:

Script de pulo de personagem:

public float forca = 500f;
public Rigidbody2D bola;
public int duplo = 2;
public AudioClip pulosom; //Variável de implementação do audio do pulo no Unity

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

			Gerenciador.inst.PlayAudio (puloSom); //Ao pular, vai tocar o som do áudio de pulo pelo Gerenciador.

			duplo--; //Esse decremento diminui 1 pulo a cada vez que se aperta "Espaço". Quando chega a 0, cai no chão para 
		}			   restaurar os 2 pulos novamente.
	}
}

void OnCollisionEnter2D(Collision2D outro) //Código para permitir pular 2 vezes caso o Objeto esteja colidindo no chão.
{
	if(outro.gameObject.CompareTag("chao"))
	{
		duplo = 2;
	}
}

#######################################################################

Script de coleta de moedas:

public float vel = 2.5f;
public int moedas = 0;
public AudioClip coin; //variável publica para introdução do audio de coleta de moedas para implementação no Unity.

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
	
	if(outro.gameobject.CompareTag("moeda")) //se o objeto colidido com o personagem for da TAG "moeda",o som da coleta do objeto será tocado 
	{										   pelo gerenciador, a coleta dele será contabilizada em +1 e o objeto será destruido.

		Gerenciador.inst.PlayAudio (coin); //Ao coletar a moeda, vai tocar um audio de coleta de moedas pelo Gerenciador.
		moeda++
		Destroy (outro.gameObject);
	}
}
*/