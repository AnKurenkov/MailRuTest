Feature: MailRuLogIn

As a user a want to Log in my testing profile on Mail.ru

@tag1
Scenario: Log in
	Given that User on the login page of MailRu
	When User enter and check username
	And User click next button
	And User enter password
	And User click submit button
	Then check User name on HomePage
