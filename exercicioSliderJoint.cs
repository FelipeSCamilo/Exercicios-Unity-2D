/*O SliderJoint é usado para adicionar um efeito de deslizamento para o objeto ao qual esse articulador for implementado.
Normalmente é usado para fazer plataformas andarem de cima para baixo, de um lado para o outro, automáticamente.
Para que o Slider funcione automáticamente, normalmente é feito um script para isso, segue a produção dele a seguir: */

public SliderJoint2D slider; //Variável pública para a introdução do Joint dentro do editor do Unity
public JointMotor2D aux;

void Start(){
	
	aux = slider.motor; //Aqui diz que a variável auxiliar representa o motor do Slider.
}

void Update(){
	
	if(slider.limitState == JointLimitState2D.LowerLimit) //Se o limite estiver mais baixo que o estipulado (lower translation),  
	{												      //a velocidade do motor será de 1. Logo após, esse 1 irá ser transportado para o
		aux.motorspeed = 1;								  //slider (slider.motor = aux).
		slider.motor = aux;
	}
	if(slider.limitState == JointLimitState2D.UpperLimit) //Se o limite estiver mais alto que o estipulado (Upper translation), 
	{													  //a velocidade do motor será de -1 e, logo após,
		aux.motorspeed = -1;						      //o slider irá receber esse -1 (slider.motor = aux).
		slider.motor = aux;
	}
}