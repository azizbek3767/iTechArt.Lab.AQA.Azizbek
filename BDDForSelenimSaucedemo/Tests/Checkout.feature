Feature: Checkout

This test feature tests the checkout function of saucedemo.com

Scenario: Checkout
	Given Open the website
	And Log in to the website
	And Add item to the cart
	And Check that item is added to the cart
	And Checkout that item
	And Fill in the checkout form
	And Check the payment information
	When Finish the checkout
	Then Redirect to the checkout confirmation page
