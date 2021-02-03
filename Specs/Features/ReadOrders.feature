Feature: ReadOrders

@mytag
Scenario: Read orders
	When i request orders
	Then the result should be a list of orders