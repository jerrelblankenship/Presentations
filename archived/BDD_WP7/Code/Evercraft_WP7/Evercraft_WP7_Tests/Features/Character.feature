Feature: Character
	In order to play the game
	as a player
	I need to have a character

Scenario: Create a New Character
	Given I have a new character
	When I give it the name of "Spiderman"
	Then the character's name should be "Spiderman"

Scenario: Character can be Good
	Given I have a new character
	When I mark the character's alignment as Good
	Then the character's alignment should be Good

Scenario: Character can be Evil
	Given I have a new character
	When I mark the character's alignment as Evil
	Then the character's alignment should be Evil

Scenario: Character can be Neutral
	Given I have a new character
	When I mark the character's alignment as Neutral
	Then the character's alignment should be Neutral