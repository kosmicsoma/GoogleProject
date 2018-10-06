Feature:
	'When I go to the Google search page, and search for an item,
		I expect to see some reference to that item in the result summary.'

Scenario:Verify user able to enter and search text in google page
	Given that I have gone to the Google page
	When I add "Selenium" to the search box
	And click the Search Button
	Then "Selenium" should be mentioned in the results
	Then count the number of links and Display the "5"th link