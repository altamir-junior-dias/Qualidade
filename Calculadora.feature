Funcionalidade: Calculadora

Contexto: Acesso a calculadora
	Quando acessar a página da calculadora

@cenarioSimples
Cenário: Adição simples
	Dado o número 50
	E a operação +
	E o número 70
	Quando clicar no igual
	Então o resultado deve ser 120

@variasAdicoes
Esquema do Cenário: Várias adições
	Dado o número <primeiro número>
	E a operação +
	E o número <segundo número>
	Quando clicar no igual
	Então o resultado deve ser <resultado>

	Exemplos: 
		| primeiro número | segundo número | resultado |
		| 10              | 10             | 20        |
		| 33              | 22             | 55        |
		| 3               | 5              | 8         |


