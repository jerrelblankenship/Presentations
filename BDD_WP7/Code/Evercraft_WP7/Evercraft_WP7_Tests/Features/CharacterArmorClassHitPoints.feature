Feature: Armor Class & Hit Points
	In order to avoid dying unexpectedly
	as a character
	I want to have an armor class and hit points

Scenario: Character has an Armor class
	Given I have a new character
	Then the Character has a default Armor Class of 10

Scenario: Character has hit points
	Given I have a new character
	Then the character has a default hit points of 5