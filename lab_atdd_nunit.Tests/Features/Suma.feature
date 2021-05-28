Feature: Como cliente quiere realizar la Suma de dos numeros para obtener un resultado

Scenario: Suma dos numeros positivos el resultado es correcto
	Given los numeros 2 y 3
	When yo sumo
	Then el resultado deberia ser 5

Scenario: Suma un numero negativo con uno positivo
	Given los numeros -1 y 3
	When yo sumo
	Then deberia ser error

Scenario: Suma dos numeros negativos
	Given los numeros -1 y -3
	When yo sumo
	Then deberia ser error
	And deberia mostrarse el error: Uno de los sumandos es negativo, no se puede realizar la suma 