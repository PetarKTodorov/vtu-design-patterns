# vtu-design-patterns

# About Application
The application register celebrities into chat room and then they can chat between each other.

## Implemented design patterns
* Creational patterns
	* Factory Method
	* Abstract Factory
* Structural patterns
	* Facade
* Behavioral patterns
	* Command
	* Mediator

## Comands
* RegisterCelebrity [userType] [firstName] [lastname] [age]
* SendMessage [senderFirstName] [senderLastname] to [reciverFirstName] [reciverLastname] [message]
* Shutdown

## Input/Output
	Input

	RegisterCelebrity YoungUser Elsie Fisher 16
	RegisterCelebrity AdultUser Angelina Jolie 45
	RegisterCelebrity AdultUser Brad Pitt 57
	SendMessage Angelina Jolie to Brad Pitt Hi, Brad!
	SendMessage Angelina Jolie to Elsie Fisher Hi, Elsie!
	Shutdown

	Output

	RegisterCelebrity YoungUser Elsie Fisher 16
	RegisterCelebrity AdultUser Angelina Jolie 45
	RegisterCelebrity AdultUser Brad Pitt 57
	SendMessage Angelina Jolie to Brad Pitt Hi, Brad!
	Send to adult user: Angelina Jolie to Brad Pitt: "Hi, Brad!"
	SendMessage Angelina Jolie to Elsie Fisher Hi, Elsie!
	Send to young users: Angelina Jolie to Elsie Fisher: "Hi, Elsie!"
	Shutdown