//Criando o script de efeito de scroll no background da cena

	public float vel = 0.1f;  //As variáveis publics permitem que elas sejam visíveis dentro do editor do Unity,
	public Renderer quad;	  //permitindo que se adapte e introduza valores (desde números até GameObjects) lá dentro mesmo.

	void start()
	{

	}

	void Update()
	{

	Vector2 offset = new Vector2(vel * Time.deltaTime, 0);
	quad.material.mainTextureOffset += offset;

    /* O Time.DeltaTime garante que a velocidade de objetos seja o mais próximo possivel, mantendo um padrão em qualquer 
    computador que esteja rodando o jogo, independente da potencial do mesmo. Mandando o resultado do calculo acima, 
    para Mesh Renderer do Quad*/
}