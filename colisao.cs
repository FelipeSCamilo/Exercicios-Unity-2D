void Start(){
	
}
void Update(){
	
}

void OnCollisionEnter2D(Collision2D outro) 
/* Aqui está sendo dado um parâmetro para o método. O "outro" representa o outro objeto que será colidido pelo objeto 
ao qual esse script estará. Por exemplo: Esse Script estará no Gameobject bola, logo o "outro" será o GameObject ao qual 
o objeto bola irá colidir.*/
{
	if(outro.Gameobject.CompareTag("madeira")) //Se o GameObject "outro" for da tag "madeira", destrua o GameObject "outro".
	{										
			Destroy (outro.gameobject);			
											    
	}	
											 
	
}