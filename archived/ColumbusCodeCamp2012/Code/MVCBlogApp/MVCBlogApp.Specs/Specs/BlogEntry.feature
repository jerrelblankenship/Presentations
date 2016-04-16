Feature: BlogEntry
	In order to share my thoughts with the world
	As a writer
	I want to be able to create blog entries

Scenario: Starting Application
	Given I navigate to the Blog Application
	Then I should see the "Blog Summary Page"

 Scenario: Adding a Blog Entry
 Given I am on the "Blog Summary Page"
 When I click on the "AddBlog" button
 Then I should see the "Blog Entry Screen"

 Scenario: Creating First Blog Entry
	Given I am on the "Blog Summary Page"
	And I click on the "AddBlog" button
	When I enter the title "First Entry"
	And I enter the body "On my way with my first blog entry"
	And I submit the form
	Then I should see the "Blog Summary Page"
	And I should see "First Entry --- On my way with my first blog entry" on the page