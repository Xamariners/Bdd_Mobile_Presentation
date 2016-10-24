Feature: Todo
	In order to manage my life efficently
	As a disorganised monkey
	I want to structure my things to do in a neat todo list

Scenario Outline:  Navigate to todo list
	Given I am on the TodoList Page
	Then I should see <amount> items
Examples: 
| amount |
| 93     |