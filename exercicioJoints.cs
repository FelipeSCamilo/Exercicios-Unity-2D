//Script para quebra do articulador DistanceJoint2D via input.

public DistanceJoint2D bola; //Variável publica para adicionar o objeto com o Distance Joint2D a ser manipulado dentro do Unity.

void Start()
{
	
}

void Update()
{
	if(Input.GetKeyDown(KeyCode.A)) //Se apertar a tecla A, a força do Distance Joint2D colocado na variável bola, será 0 (ou seja, quebrará)
	{
		bola.BreakForce = 0;
	}
}