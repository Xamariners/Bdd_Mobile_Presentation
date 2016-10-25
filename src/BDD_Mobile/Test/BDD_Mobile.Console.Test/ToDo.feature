Feature: Todo List Manager
	In order to manage my life efficently
	As a disorganised monkey
	I want to structure my things to do in a neat todo list

Scenario Outline: Count Todo List items
	Given I am on the TodoList Page
	Then I should see <amount> items
Examples: 
| amount |
| 93     |


Scenario Outline: Todo List should be ordered alphabatically
	Given I am on the TodoList Page
	Then the first item name is "<firstItemName>" 
	And the last item name is "<lastItemName>"
Examples: 
| firstItemName                          | lastItemName         |
| Arrange a football match at the office | Write two blog posts |


Scenario Outline: View Todo item details
	Given I am on the TodoList Page
	When I tap on the item with name "<itemName>"
	Then I am on the TodoItemDetail Page
	And the item name is "<itemName>"
	And the item description is "<itemDescription>"
	And the item status is "<itemStatus>"

Examples: 
| itemName         | itemDescription | itemStatus |
| Buy a new guitar | Get a fender    | Open       |