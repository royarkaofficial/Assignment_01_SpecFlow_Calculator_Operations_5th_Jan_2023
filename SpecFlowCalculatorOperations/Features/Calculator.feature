Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculatorOperations/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
    Given the first number is 5
    And the second number is 10
    When the two numbers are added
    Then the result should be 15

Scenario: Multiply two numbers
    Given the first number is 5
    And the second number is 10
    When the two numbers are multiplied
    Then the result should be 50

  Scenario: Subtract two numbers
    Given the first number is 15
    And the second number is 7
    When the two numbers are subtracted
    Then the result should be 8

  Scenario: Divide two numbers
    Given the first number is 20
    And the second number is 4
    When the two numbers are divided
    Then the result should be 5